//Data_Layer Class for SQL Functionality
//Programmed by: Markus Reynolds
//08/31/2019
using System;

namespace EvasWebsite.Data
{
    /* record */
    public class Product
    {
        public int productID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; }
        public bool Available { get; set; }
        public string PicturePath { get; set; }
    }
}