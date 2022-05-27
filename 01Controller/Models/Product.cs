using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01Controller.Models
{
    public class Product  //產品實體
    {
        //物件類別
        public string PId { get; set; } //品號屬性
        public string PName { get; set; } //品名屬性
        public int Price { get; set; } //價格屬性

    }
}