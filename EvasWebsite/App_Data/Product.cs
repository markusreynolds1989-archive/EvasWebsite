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


        public string displayProduct()
        {
            /* this isn't perfect, it's probably best to clean this up to work
             * better with CSS 
             */
            createProduct();
            string HTML =
            "<form id = 'item'> " +
            $"<h1>{Title} </h1></br>" +
            $"{Description} </br>" +
            $"{Quantity} </br>" +
            $"<img src = '{PicturePath}' + </br>" +
            "</form>";
            return HTML;
        }

        public void createProduct()
        {
            ID = 23;
            Title = "Bow";
            Description = "BLAH BLAH BLAH";
            Quantity = 2;
            Available = true;
            PicturePath = "...";
        }

        public static implicit operator List<object>(Product v)
        {
            throw new NotImplementedException();
        }
    }

}