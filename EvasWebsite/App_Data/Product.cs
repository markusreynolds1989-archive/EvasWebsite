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
                globalMethods.printDebug(Data_Layer.getProduct().PicturePath);
            string HTML = $@"<div class='container'>
            <div class='card'>
                <img
                    class='card-img-top'
                    ID='imgPicturePreview'
                    image src='{Data_Layer.getProduct().PicturePath}'
                    alt='product image'
                    Height='300'
                    widht='100' />
                <div class='card-title'>
                    <h5>
                        <label
                                id = 'lbl{Data_Layer.getProduct().Title}'>
                                {Data_Layer.getProduct().Title} </label>
                    </h5>
                    <div class='card-body'>
                        <p>
                            <label
                                id = 'lbl{Data_Layer.getProduct().Description}'>
                                {Data_Layer.getProduct().Description}</label>
                        </p>
                        <p>
                            <label>Quantity: </label>
                            <label
                                ID = 'lbl{Data_Layer.getProduct().Quantity}'>
                                {Data_Layer.getProduct().Quantity}</label>
                                
                        </p>
                        <p>
                            <label>Cost: $ </label>
                            <label
                                ID = 'lblCostPre' </label>
                        </p>
                    </div>
                </div>
            </div>";
            return HTML;
            }
            catch(Exception ex)
            {
                globalMethods.printDebug($"Display Products Error:\n {ex}");
                return "";
            }
        }
    }
}