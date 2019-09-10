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


        public string displayProducts(string Title
                                    , string Description
                                    , int Quantity
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
                            <label>Cost: $ </label>
                            <label
                                ID = 'lblCostPre' </label>
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