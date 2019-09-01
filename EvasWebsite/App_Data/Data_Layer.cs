//Data_Layer Class for SQL Functionality
//Programmed by: Markus Reynolds
//08/31/2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Web;
using System.Data;

namespace EvasWebsite.Data
{
    public class Data_Layer
    { 
        /// <summary>
        /// Boolean for adding items to the database
        /// </summary>
        /// <param name="Title"></param>
        /// <param name="Desc"></param>
        /// <param name="Quant"></param>
        /// <param name="Cost"></param>
        /// <param name="Pic"></param>
        /// <returns>True or False</returns>
        /// 
        public static bool AddProduct(string Title
            , string Desc
            , int Quant
            , float Cost
            , string Pic)
        {
            bool recordSaved;

            SqlTransaction myTransaction = null;

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
    }
}
