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
            createProduct();
            string HTML = $"<label text = {Title}/> <br/> <label text = {Description}/> <br/> <label text = {Quantity}/> <br/> <img src = '{PicturePath}'";
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