//Programmer: Ivoire Morrell
//Program Name: Currency Format Converter
//Date: September 5, 2019
// Description: The CUrrency format converter takes three different integers entered by the user, 
//calculates the total, average, and the hugh/low from these numbers then displays the total in
//four different currencies 

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //create varibles the will be used for user input and to calculate total, average
            double numOne;
            double numTwo;
            double numThree;

            double total;
            double average;
            double high;
            double low;

            //welcome the user to the program and ask them to enter three numbers

            Console.WriteLine("Welcome to the Currency format converter! please enter a number");

            numOne = Convert.ToDouble(Console.ReadLine());

            //used to make a space
            Console.WriteLine();

            Console.WriteLine("Please enter a second number");

            numTwo = Convert.ToDouble(Console.ReadLine());

            //used to make a space
            Console.WriteLine();

            Console.WriteLine("Please enter a third number");

            numThree = Convert.ToDouble(Console.ReadLine());

            //used to make a space
            Console.WriteLine();

            //create a caluculator class object to calculate total, average, and high/low
            Calculator cali = new Calculator(numOne, numTwo, numThree);

            //calculate the total of these three numbers
            total = cali.calTotal();

            //Calculate the average 
            average = cali.calAverage();

            //determine which number is the highest
            high = cali.calHigh();

            //Detrmine which number is the lowest
            low = cali.calLow();

            //display the total, average, high, and low
            cali.displayCal();

            //print and display total in US
            Console.WriteLine(total.ToString("C", CultureInfo.CurrentCulture));

            Console.WriteLine();

            //print and display total in Swedish
            Console.WriteLine(total.ToString("C", CultureInfo.CreateSpecificCulture("sv-SE")));

            Console.WriteLine();

            //print and display total in Japanese
            Console.WriteLine(total.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));

            Console.WriteLine();

            //print and display total in Thai 
            Console.WriteLine(total.ToString("C", CultureInfo.CreateSpecificCulture("th-TH")));

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
