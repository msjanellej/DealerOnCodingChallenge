﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
                bool condition = true;
                while (condition)
                {
                    if (answer == "yes")
                    {
                        continueShopping = true;
                        condition = false;
                    }
                    else if (answer == "no")
                    {
                        continueShopping = false;
                        condition = false;
                    }
                    else
                    {
                        Console.WriteLine("Please type either yes or no");
                        answer = Console.ReadLine();
                        condition = true;
                        continue;
                    }

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
            bool condition = true;
            while (condition)
            {
                if (taxAnswer == "no")
                {
                    item.IsTaxable = true;
                    condition = false;
                }
                else if (taxAnswer == "yes")
                {
                    item.IsTaxable = false;
                    condition = false;
                }
                else
                {
                    Console.WriteLine("You did not make a valid selection, type yes or no");
                    taxAnswer = Console.ReadLine();
                    condition = true;
                    continue;
                }
            }
            condition = true;      
            Console.WriteLine("Is the item imported? Enter yes or no");
            string importAnswer = Console.ReadLine().ToLower();
            condition = true;
            while (condition)
            {
                if (importAnswer == "yes")
                {
                    item.IsImported = true;
                    condition = false;
                }
                else if (importAnswer == "no")
                {
                    item.IsImported = false;
                    condition = false;
                }
                else
                {
                    Console.WriteLine("You did not make a valid selection, type yes or no");
                    importAnswer = Console.ReadLine();
                    condition = true;
                    continue;
                }

            }      
            return item;
        }
        public static void PrintReceipt(List<ItemForSale> totalSale, double totalItemPrice, double totalTax, double grandTotal)
        {
            List<string> itemsPrinted = new List<string> { };
            for (int i = 0; i < totalSale.Count; i++)
            {
                List<ItemForSale> items = totalSale.FindAll(t => t.ItemName == totalSale[i].ItemName);
                if (items.Count > 1 && itemsPrinted.Contains(totalSale[i].ItemName) == false)
                {
                    Console.WriteLine(totalSale[i].ItemName + ": " + totalSale[i].Price * items.Count + " (" + items.Count + "@ " + totalSale[i].Price + ")");

                }
                else if (items.Count == 1)
                {
                    Console.WriteLine(totalSale[i].ItemName + ": " + totalSale[i].Price.ToString());
                }
                itemsPrinted.Add(totalSale[i].ItemName);
                
            }
            Console.WriteLine("Sales Taxes: " + totalTax);
            Console.WriteLine("Total: " + grandTotal);
        }
    }
}
