using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using EvasWebsite.Data;

namespace EvasWebsite
{
    public class Product_Functions
    {
        /* Get Product Query */
        public static List<Product> getProduct()
        {
            SqlConnection conn = new SqlConnection(
                "Data Source=s08.everleap.com;" +
                "Initial Catalog=DB_5349_evaswebsite;" +
                "User ID=DB_5349_evaswebsite_user;" +
                "Password=Sonics.256");

            using (conn)
            {
                try
                {
                    conn.Open();
                    SqlCommand command = conn.CreateCommand();
                    string strSQL = "Select * from tblProducts";
                    command.CommandType = CommandType.Text;
                    command.CommandText = strSQL;
                    SqlDataReader reader = command.ExecuteReader();
                    /* list of Products here using Product Record Template*/
                    List<Product> products = new List<Product>();
                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            Title = reader.GetString(1)
                            ,
                            Description = reader.GetString(2)
                            ,
                            Quantity = reader.GetInt32(3)
                            ,
                            Cost = reader.GetDouble(4)
                            ,
                            PicturePath = reader.GetString(5)
                        });
                    }
                    /* we need to consider how this is set up here */
                    conn.Close();
                    globalMethods.printDebug("SET");
                    return products;

                }
                catch (Exception ex)
                {
                    globalMethods.printDebug($"Get Products Error:\n {ex}");
                    return null;
                }
            }
        }

        /* display product function */
        public string displayProducts(string Title
                                    , string Description
                                    , int Quantity
                                    , double Cost
                                    , string PicturePath)
        {
            /* Create a string
             * that is HTML that displays our products
             * in a square relative to other squares
             */
            try
            {
                string HTML = $@"<div class='container'>
            <div class='card' style='width: 18rem;'>
                 <img
                    class='card-img-top'
                    ID='img{PicturePath}'
                    src={PicturePath}
                    alt='product image'/>

                <div class='card-title'>
                    <h5>
                        <label
                                id = 'lbl{Title}'>
                                {Title} </label>
                    </h5>

                    <div class='card-body'>
                        <p>
                            <label
                                id = 'lbl{Description}'>
                                {Description}</label>
                        </p>

                        <p>
                            <label>Quantity: </label>
                            <label
                                ID = 'lbl{Quantity}'>
                                {Quantity}</label>
                                
                        </p>

                        <p>
                            <label>Cost: ${Cost} </label>
                            <label
                                ID = 'lbl{Cost}' </label>
                        </p>
                    </div>
                </div>
                    <div class = 'container'>
                        <input type = button
                        id = '{Title}buy'
                        class = 'btn btn-success'
                        value ='Add to Cart'/> 
                    </div>
                </div>
            </div>
            </br>";
                return HTML;
            }
            catch (Exception ex)
            {
                globalMethods.printDebug($"Display Products Error:\n {ex}");
                return "";
            }
        }
    }
}