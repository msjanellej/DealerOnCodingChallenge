using System;
using System.Collections.Generic;
using System.Text;

namespace DealerOn
{
    public static class Calculations
    {
        public static double GetProductTotals(List<ItemForSale> items)
        {
            double runningTotal = 0;
            for (int i = 0; i < items.Count; i++)
            {
                runningTotal += items[i].Price;
                
            }
            return runningTotal;
        }
        public static double CalculateTax(ItemForSale item, double taxRate)
        {
            double tax = item.Price * taxRate;
            double roundedTax = Math.Round(tax * 20, MidpointRounding.ToPositiveInfinity) / 20;
            return roundedTax;
        }
        public static double CalculateTotalTax(List<ItemForSale> items)
        {
            double totalTax = 0;
            for (int i = 0; i < items.Count; i++)
            {
                double totalTaxPerItem = items[i].SalesTax + items[i].ImportTax;
                totalTax += totalTaxPerItem;
            }
            return totalTax;
        }
        public static double CalculateTotalCost(double runningTotal, double tax)
        {
            double grandTotal = runningTotal + tax;
            return grandTotal;
        }
        

    }
}
