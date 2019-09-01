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
        public int Cost { get; set; }
        public bool Available { get; set; }
        public string PicturePath { get; set; }


        public string displayProducts()
        {
            /* this isn't perfect, it's probably best to clean this up to work
             * better with CSS 
             */
            string HTML =
            "<div id = 'item'> " +
            $"<h1>{Title} </h1></br>" +
            $"Description: {Description} </br>" +
            $"Quantity: {Quantity} </br>" +
            $"Cost: ${Cost} </br>" +
            $"<img src = '{PicturePath}' + </br>" +
            "<input type='button' value ='Add To Cart' class = 'Button'/>" + 
            "</div>";
            return HTML;
            /* how do we dynamically add ids to the buttons? SQL variables */
        }

        public void createProduct(
              string Title
            , string Description
            , int Quantity
            , int Cost
            , bool Available
            , string PicturePath){ 


            this.Title = Title;
            this.Description = Description;
            this.Quantity = Quantity;
            this.Cost = Cost;
            this.Available = Available;
            this.PicturePath = PicturePath;
            }
        }
    }