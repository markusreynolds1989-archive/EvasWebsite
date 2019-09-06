using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvasWebsite
{
    public static class globalMethods
    {
        public static void printDebug(string input)
        {
            System.Diagnostics.Debug.WriteLine
                  ("*****ALERT*****\n" +
                   $"{input} \n" +
                   "*******ENDALERT********\n");
        }
    }
}