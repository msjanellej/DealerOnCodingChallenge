﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DealerOn
{
    public static class UserInterface
    {
        public static List<ItemForSale> ShoppingTrip()
        {
            List<ItemForSale> shoppingBasket = new List<ItemForSale>();
            bool continueShopping = true;
            Console.WriteLine("Welcome To Our Store");
            while (continueShopping)
            {
                ItemForSale productToBuy = SelectItem();
                shoppingBasket.Add(productToBuy);
                Console.WriteLine("Would you like to add another item to your basket, yes/no?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes")
                {
                    continueShopping = true;
                }
                else if (answer == "no")
                {
                    continueShopping = false;
                }
                else
                {
                    Console.WriteLine("Please type either yes or no");
                    Console.ReadLine();
                }
            }
            return shoppingBasket;
        }
        public static ItemForSale SelectItem()
        {
            ItemForSale item = new ItemForSale();
            Console.WriteLine("Please enter the item's Name:");
            item.ItemName = Console.ReadLine();
            Console.WriteLine("What is the item's price?");
            item.Price = Double.Parse(Console.ReadLine());
            Console.WriteLine("Is The Item in one of the following categories: Food, Medicine, Books? Enter yes or no");
            string taxAnswer = Console.ReadLine().ToLower();
            if (taxAnswer == "no")
            {
                item.IsTaxable = true;
            }         
            Console.WriteLine("Is the item imported? Enter yes or no");
            string importAnswer = Console.ReadLine().ToLower();
            if (importAnswer == "yes")
            {
                item.IsImported = true;
            }
            return item;
        }
        public static void PrintReceipt(List<ItemForSale> totalSale, double totalItemPrice, double totalTax, double grandTotal)
        {
            for (int i = 0; i < totalSale.Count; i++)
            {
                Console.WriteLine(totalSale[i].ItemName + ": "+totalSale[i].Price);
            }
            Console.WriteLine("Sales Taxes: " + totalTax);
            Console.WriteLine("Total: " + grandTotal);
        }
    }
}
