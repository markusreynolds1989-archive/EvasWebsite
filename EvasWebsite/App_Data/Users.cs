using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvasWebsite.Data
{
    public class Users
    {
        public int userID { get; set; }
        public string userName { get; set; }
        public string Password { get; set; }
        public int securityLevel {get;set;}

        /* apparently not a secure method */
        public string hash(string password)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = System.Text.Encoding.ASCII.GetString(data);
            return hash;
        }

        /*encrypt a password */
        public string encryptPassword(string password) => hash(password);

    }
}