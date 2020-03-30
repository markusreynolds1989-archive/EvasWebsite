using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using EvasWebsite.Data;

namespace EvasWebsite
{
    public class Functions_Product
    {

        /* Add Record_Product Query */
        public static bool AddProduct(string Title
           , string Desc
           , int Quant
           , double Cost
           , string Pic)
        {
            bool recordSaved;

            SqlTransaction myTransaction = null;

            SqlConnection conn = new SqlConnection(
                "Data Source=s08.everleap.com;" +
                "Initial Catalog=DB_5349_evaswebsite;" +
                "User ID=DB_5349_evaswebsite_user;" +
                "Password=");

            using (conn)
            {
                try
                {
                    conn.Open();
                    SqlCommand command = conn.CreateCommand();
                    myTransaction = conn.BeginTransaction();
                    command.Transaction = myTransaction;
                    string strSQL = "Insert into tblProducts (Title, Description, Quant, Cost, Picture, Updt_dt_tm)" +
                        $"values(@Title,@Desc,@Quant,@Cost,@Pic,CURRENT_TIMESTAMP)";
                    command.CommandType = CommandType.Text;
                    command.CommandText = strSQL;
                    command.Parameters.AddWithValue("@Title", Title);
                    command.Parameters.AddWithValue("@Desc", Desc);
                    command.Parameters.AddWithValue("@Quant", Quant);
                    command.Parameters.AddWithValue("@Cost", Cost);
                    command.Parameters.AddWithValue("@Pic", Pic);
                    command.ExecuteNonQuery();
                    myTransaction.Commit();
                    conn.Close();
                    recordSaved = true;
                    System.Diagnostics.Debug.WriteLine(
                        "*********ALERT*********\n" +
                        "Uploaded\n" +
                        "**********ENDALERT******\n)");
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(
                        "\n***********ALERT*********" +
                        "\nAdd_Products Error:\n" +
                        ex.ToString() +
                        "\n ******ENDALERT*********");

                    myTransaction.Rollback();
                    recordSaved = false;
                }
                return recordSaved;
            }
        }

        public static bool modifyProduct(int ProductID
           , string Title
           , string Desc
           , int Quant
           , double Cost
           , string Pic)
        {
            bool recordSaved;

            SqlTransaction myTransaction = null;

            SqlConnection conn = new SqlConnection(
                "Data Source=s08.everleap.com;" +
                "Initial Catalog=DB_5349_evaswebsite;" +
                "User ID=DB_5349_evaswebsite_user;" +
                "Password=");

            using (conn)
            {
                try
                {
                    conn.Open();
                    SqlCommand command = conn.CreateCommand();
                    myTransaction = conn.BeginTransaction();
                    command.Transaction = myTransaction;

                    /*SQL String */
                    string strSQL = 
                        $@"Update tblProducts set
                        Title = @Title 
                        , Description = @Desc
                        , Quant = @Quant
                        , Cost = @Cost
                        , Picture = @Pic
                        , Updt_dt_tm = CURRENT_TIMESTAMP
                        where Id = @ProductID";

                    command.CommandType = CommandType.Text;
                    command.CommandText = strSQL;
                    command.Parameters.AddWithValue("@ProductID", ProductID);
                    command.Parameters.AddWithValue("@Title", Title);
                    command.Parameters.AddWithValue("@Desc", Desc);
                    command.Parameters.AddWithValue("@Quant", Quant);
                    command.Parameters.AddWithValue("@Cost", Cost);
                    command.Parameters.AddWithValue("@Pic", Pic);
                    command.ExecuteNonQuery();
                    myTransaction.Commit();
                    conn.Close();
                    recordSaved = true;
                    System.Diagnostics.Debug.WriteLine(
                        "*********ALERT*********\n" +
                        "Uploaded\n" +
                        "**********ENDALERT******\n)");
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(
                        "\n***********ALERT*********" +
                        "\nModify_Products Error:\n" +
                        ex.ToString() +
                        "\n ******ENDALERT*********");

                    myTransaction.Rollback();
                    recordSaved = false;
                }
                return recordSaved;
            }
        }

        public static Record_Product getOneProductById(int ProductID)
        {
            SqlConnection conn = new SqlConnection(
                "Data Source=s08.everleap.com;" +
                "Initial Catalog=DB_5349_evaswebsite;" +
                "User ID=DB_5349_evaswebsite_user;" +
                "Password=");

            using (conn)
            {
                try
                {
                    conn.Open();
                    SqlCommand command = conn.CreateCommand();
                    string strSQL = "Select * from tblProducts where ID = @ProductID";
                    command.CommandType = CommandType.Text;
                    command.CommandText = strSQL;
                    command.Parameters.AddWithValue("@ProductID",ProductID);
                    /*Return one product where ID matches*/
                    SqlDataReader reader = command.ExecuteReader();
                    Record_Product product = new Record_Product();
                    while (reader.Read()){
                        product.Title = reader.GetString(1);
                        product.Description = reader.GetString(2);
                        product.Quantity = reader.GetInt32(3);
                        product.Cost = reader.GetDouble(4);
                        product.PicturePath = reader.GetString(5);
                    }
                    conn.Close();
                    globalMethods.printDebug("get one product set");
                    return product;
                }
                catch (Exception ex)
                {
                    globalMethods.printDebug($"Get One Product Error:\n {ex}");
                    return null;
                }
            }
        }

        /* Get Record_Product Query */
        public static List<Record_Product> getProduct()
        {
            SqlConnection conn = new SqlConnection(
                "Data Source=s08.everleap.com;" +
                "Initial Catalog=DB_5349_evaswebsite;" +
                "User ID=DB_5349_evaswebsite_user;" +
                "Password=");

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
                    /* list of Products here using Record_Product Record Template*/
                    List<Record_Product> products = new List<Record_Product>();
                    while (reader.Read())
                    {
                        products.Add(new Record_Product
                        {
                            productID = reader.GetInt32(0)
                            ,
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

        /* create a table for modification */
        public static string tableProducts(int ProductID
                                    , string Title
                                    , string Description
                                    , int Quantity
                                    , double Cost
                                    , string PicturePath)
        {
            try
            {
                string table = $@"
                    <tr>
                        <th scope='row'>
                        {ProductID}
                        </th>
                        <td> {Title} </td>
                        <td> {Description} </td>
                        <td> {Quantity} </td>
                        <td> {Cost} </td>
                        <td> <img class='img-thumbnail' src = '{PicturePath}'/> </td>
                   </tr>
                ";
                return table;
            }
            catch (Exception ex)
            {
                globalMethods.printDebug($"Display Table Error:\n {ex}");
                return "";
            }
        }

        /* display product function */

        public static string displayProducts(string Title
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
