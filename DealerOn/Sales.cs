using System;
using System.Collections.Generic;
using System.Text;

namespace DealerOn
{
    class Sales
    {
        public void GoShopping()
        {
            List<ItemForSale> itemsToPurchase = UserInterface.ShoppingTrip();
            GetTaxForItems(itemsToPurchase);
            double totalPriceofItems = Calculations.GetProductTotals(itemsToPurchase);
            double totalTaxofItems = Calculations.CalculateTotalTax(itemsToPurchase);
            double grandTotal = Calculations.CalculateTotalCost(totalPriceofItems, totalTaxofItems);
            UserInterface.PrintReceipt(itemsToPurchase, totalPriceofItems, totalTaxofItems, grandTotal);
        }
        public void GetTaxForItems(List<ItemForSale> allItems)
        {
            for (int i = 0; i < allItems.Count; i++)
            {
                if (allItems[i].IsTaxable == true)
                {
                    allItems[i].SalesTax = Calculations.CalculateTax(allItems[i], .10);
                }
                if (allItems[i].IsImported == true)
                {
                    allItems[i].ImportTax = Calculations.CalculateTax(allItems[i], .05);
                }

            }
        }



    }
   
}
