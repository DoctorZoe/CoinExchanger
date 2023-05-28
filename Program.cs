using System;

namespace CoinExchanger
{
    internal class Program
    {
        
                
        static void Main(string[] args)
        {
            string input;
            float changeValue;
            int totalCoins;
            //support variables;

            while (true)
            {
                Console.Write("Please enter the value you wish to produce as a monetary change or type anything else to stop: ");
                input = Console.ReadLine();
                totalCoins = 0;

                if (!float.TryParse(input, out float result)) break; //exits in case the user types anything other than a suitable value.

                changeValue = float.Parse(input); //gets input from the user and converts it into a float value.
                changeValue *= 100;


                //aiming for simplicity, each coin is treated individually instead of through a loop or an array.
                Console.WriteLine("Using " + (int)changeValue / 200 + "x $2.00CAD coins in the exchange.");
                totalCoins += (int)changeValue / 200;
                changeValue %= 200;
                
                Console.WriteLine("Using " + (int)changeValue / 100 + "x $1.00CAD coins in the exchange.");
                totalCoins += (int)changeValue / 100;
                changeValue %= 100;
                
                Console.WriteLine("Using " + (int)changeValue / 50 + "x $0.50CAD coins in the exchange.");
                totalCoins += (int)changeValue / 50;
                changeValue %= 50;
                
                Console.WriteLine("Using " + (int)changeValue / 25 + "x $0.25CAD coins in the exchange.");
                totalCoins += (int)changeValue / 25;
                changeValue %= 25;

                Console.WriteLine("Using " + (int)changeValue / 10 + "x $0.10CAD coins in the exchange.");
                totalCoins += (int)changeValue / 10;
                changeValue %= 10;

                Console.WriteLine("Using " + (int)changeValue / 5 + "x $0.05CAD coins in the exchange.");
                totalCoins += (int)changeValue / 5;
                changeValue %= 5;

                Console.WriteLine("Using " + (int)changeValue / 1 + "x $0.01CAD coins in the exchange.");
                totalCoins += (int)changeValue / 1;

                Console.WriteLine("The full change includes " + totalCoins + " coins.\n");
                //Produce the result to the user.

            }
        }
    }
}
