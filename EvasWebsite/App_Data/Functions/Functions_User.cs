using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EvasWebsite
{
    public class Functions_User
    {
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
                "Password=");

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



        /* Return security level for the user */
        public static int verifyUser(string UserName
           , string Password)
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
