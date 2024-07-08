using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppStockTaking.Models
{
    public class Product
    {
        public int id { get;set; }
        public string Name { get;set; }
        public int ManufacturerId { get; set; } = 0;
        public string ManufacturerName { get; set; }


    }
}
