using System;
using System.Collections.Generic;
using System.Text;

namespace DealerOn
{
    public class ItemForSale
    {
        public string ItemName { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public bool IsTaxable { get; set; }
        public bool IsImported { get; set; }
        public double SalesTax { get; set; }
        public double ImportTax { get; set; }

    }
}
