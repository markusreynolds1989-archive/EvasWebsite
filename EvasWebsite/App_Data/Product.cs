using System;

namespace EvasWebsite.Data
{
    public class Product
    {
        public int productID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public float Cost { get; set; }
        public bool Available { get; set; }
        public string PicturePath { get; set; }


        public string displayProducts()
        {
            /* Create a string
             * that is HTML that displays our products
             * in a square relative to other squares
             */
            try
            {
                Data_Layer.getProduct();
                return "";
            }
            catch(Exception ex)
            {
                globalMethods.printDebug($"Display Products Error:\n {ex}");
                return "";
            }
        }
    }
}