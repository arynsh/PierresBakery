using System;
using System.Collections.Generic;
// using Bakery;

namespace Bakery
{ 
    public class Program
    {

        static void Main()
        { 
            // Animal donkey1 = new Animal ("Don Quixote", "male", "Area 1", "donkey");   //name, gender, location, animal type
            // Animal donkey2 = new Animal ("Don Nutella", "female", "Area 1", "donkey");
            // Animal Emu1 = new Animal ("Waffle", "female", "Area 2", "emu");
            
            // List<Animal> Animals = new List<Animal>() { donkey1, donkey2, Emu1 };

            Console.WriteLine("Welcome to Pierre's Bakery! Or as we like to say, Bienvenue! We have loaves of bread for $5 each and pastries for $2 each. We are running a Christmas special for the month of December where our loaves of bread are buy 2 get 1 free and our pastries are 3 for $5!");
            Console.WriteLine("Please enter the number of loaves you would like to purchase today: ['0' to skip to pastries]");
            string stringBread = Console.ReadLine();
            int numBread = int.Parse(stringBread);
            Console.WriteLine("Please enter the number of pastries you would like to purchase today: ['0' to skip to checkout]");
            string stringPastries = Console.ReadLine();
            int numPastries = int.Parse(stringPastries);
            
            if (numBread != 0)
            {
                Animal.LookUpByTypeMethod(Animals);
                
            } else 
            {
                Console.WriteLine("Would you like to search by area? ['Y' for yes, 'Enter' for no]");
                string answer2 = Console.ReadLine();
                if (answer2 == "Y" || answer2 == "y")
                {
                    Animal.LookUpByAreaMethod(Animals);
                } 
                else
                {
                    Console.WriteLine("Would you like to exit? ['Y' for yes, 'Enter' for no]");
                    string answer3 = Console.ReadLine();
                    if (answer3 == "Y" || answer3 == "y")
                    {
                        Console.WriteLine("See you next time!!");
                    }
                    else{
                        Main();
                    }
                }
            }
        }
    }
}