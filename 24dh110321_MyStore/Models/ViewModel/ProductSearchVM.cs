using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _24dh110321_MyStore.Models.ViewModel
{
    public class ProductSearchVM
    {
        public string SearchTerm { get; set; }
        
        public decimal ? MinPrice { get; set; }
        public decimal ? MaxPrice { get; set; }

        public List<Product>Products { get; set; }
    }
}