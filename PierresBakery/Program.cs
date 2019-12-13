using System;
using System.Collections.Generic;

namespace Bakery
{ 
    public class Program
    {

        static void Main()
        { 
            // List<int> bakedGoods = new List<int> {};

            Console.WriteLine("Welcome to Pierre's Bakery! Or as we like to say, Bienvenue! We have loaves of bread for $5 each and pastries for $2 each. We are running a Christmas special for the month of December where our loaves of bread are buy 2 get 1 free and our pastries are 3 for $5!");
            Console.WriteLine("Please enter the number of loaves you would like to purchase today: ['0' to skip to pastries]");
            string stringBread = Console.ReadLine();
            int numBread = int.Parse(stringBread);
            Console.WriteLine("How many pastries would you like? ['0' to skip to checkout]");                string stringPastries = Console.ReadLine();
            int numPastries = int.Parse(stringPastries);

            Bread breads = new Bread (numBread, 5);  
            Pastry pastries = new Pastry (numPastries, 2); 

            int breadCost = breads.CalculateCost();
            int pastryCost = pastries.CalculateCost(); 
            int total = (breadCost + pastryCost);
            string stringTotal = total.ToString();
            Console.WriteLine(stringTotal);

            // if (numBread != 0)
            // {
            //     bakedGoods.Add(numBread);
            //     // Animal.LookUpByTypeMethod(Animals);
            //     Console.WriteLine("And how many pastries would you like? '0' to skip to checkout]");
            //     string stringPastries = Console.ReadLine();
            //     int numPastries = int.Parse(stringPastries);
                
            //     if (numPastries != 0)
            //     {
            //         bakedGoods.Add(numPastries);
            //         checkout();
            //     }
            //     else 
            //     {
            //         checkout();
            //     }

            // } 
            // else 
            // {
            //     bakedGoods.Add(0);
            //     Console.WriteLine("How many pastries would you like? '0' to skip to checkout]");
            //     string stringPastries = Console.ReadLine();
            //     int numPastries = int.Parse(stringPastries);

            //     if (numPastries != 0)
            //     {
            //         bakedGoods.Add(numPastries);
            //         checkout();
            //     } 
            //     else
            //     {
            //         Console.WriteLine("It seems you have not added anything to your cart today. Would you like to buy bread or pastries? ['Y' for yes, 'Enter' for no]");
            //         string answer = Console.ReadLine();
            //         if (answer == "Y" || answer == "y")
            //         {
            //             Main();
            //         }
            //         else
            //         {
            //             Console.WriteLine("Thank you for coming in! We hope to see you again soon.");
            //         }
            //     }
            // }
        }
    }
}