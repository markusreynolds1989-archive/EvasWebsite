using System;
using System.Collections.Generic;

namespace EvasWebsite.Data
{
    public class Product
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public bool Available { get; set; }
        public string PicturePath { get; set; }


        public string displayProducts()
        {
            /* this isn't perfect, it's probably best to clean this up to work
             * better with CSS 
             */
            string HTML =
            "<form id = 'item'> " +
            $"<h1>{Title} </h1></br>" +
            $"{Description} </br>" +
            $"{Quantity} </br>" +
            $"<img src = '{PicturePath}' + </br>" +
            "</form>";
            return HTML;
        }

        public void createProducts(
              int ID
            , string Title
            , string Description
            , int Quantity
            , bool Available
            , string PicturePath)
        {
            var product = new Product();
            product.ID = ID ++;
            product.Title = Title;
            product.Description = Description;
            product.Quantity = Quantity;
            product.Available = Available;
            product.PicturePath = PicturePath;
        }
    }

}