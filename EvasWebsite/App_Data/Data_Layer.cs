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

        /// <summary>
        /// Adds a new user with the following parameters:
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <param name="SecurityLevel"></param>
        /// <returns>true or false</returns>
        public static bool AddUser(string UserName
            , string Password
            , int SecurityLevel)
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
                    string strSQL = "Insert into tblUsers (UserName, Password, SecurityLevel,Updt_dt_tm)" +
                        $"values(@UserName,@Password,@SecurityLevel,CURRENT_TIMESTAMP)";
                    command.CommandType = CommandType.Text;
                    command.CommandText = strSQL;
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@SecurityLevel", SecurityLevel);
                    command.ExecuteNonQuery();
                    myTransaction.Commit();
                    conn.Close();
                    recordSaved = true;
                    System.Diagnostics.Debug.WriteLine(
                        "*********ALERT*********\n" +
                        "Uploaded\n" +
                        "**********ENDALERT******\n");
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(
                        "\n***********ALERT*********" +
                        "\nAdd_User Error:\n" +
                        ex.ToString() +
                        "\n ******ENDALERT*********");

                    myTransaction.Rollback();
                    recordSaved = false;
                }
                return recordSaved;
            }
        }

        /* Get Product Query */
        public static bool getProduct()
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
                    if (reader.HasRows)
                    {
                        var product = new Product();
                        product.Title = reader.GetString(1);
                        product.Description = reader.GetString(2);
                        product.Cost = reader.GetFloat(3);
                        product.Quantity = reader.GetInt32(4);
                        globalMethods.printDebug(product.ToString());
                    }
                    conn.Close();
                    globalMethods.printDebug("SET");
                    return true;

                }
                catch (Exception ex)
                {
                    globalMethods.printDebug($"Get Products Error:\n {ex}");
                    return false;
                }
            }
        }




        /* Return security level for the user */
        public static int verifyUser(string UserName
           , string Password)
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
                    string strSQL = "Select securityLevel from tblUsers where UserName = @Username and Password = @Password";
                    command.CommandType = CommandType.Text;
                    command.CommandText = strSQL;
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.ExecuteNonQuery();
                    int securityLevel = ((int)command.ExecuteScalar());
                    conn.Close();
                    System.Diagnostics.Debug.WriteLine(
                        "*********ALERT*********\n" +
                        "Verified\n" +
                        "securityLevel\n" +
                        "**********ENDALERT******\n");
                    return securityLevel;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(
                        "\n***********ALERT*********" +
                        "\nAdd_User Error:\n" +
                        ex.ToString() +
                        "\n ******ENDALERT*********");
                }
                return 4;
            }
        }
    }
}
