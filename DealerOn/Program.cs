using System;
using System.Collections.Generic;

namespace DealerOn
{
    class Program
    {
        static void Main(string[] args)
        {

            //Sales sale = new Sales();
            //sale.GoShopping();

            ItemForSale item1 = new ItemForSale();
            ItemForSale item2 = new ItemForSale();
            ItemForSale item3 = new ItemForSale();
            List<ItemForSale> itemList = new List<ItemForSale>();
            item1.ItemName = "Book";
            item2.ItemName = "Book";
            item3.ItemName = "Chocolate Bar";
            item1.Price = 12.49;
            item2.Price = 12.40;
            item3.Price = 1.50;
            itemList.Add(item1);
            itemList.Add(item2);
            itemList.Add(item3);
            Test.PrintReceipt(itemList, 26.48, 0, 26.48);
            
                
            


        
    }
}
