using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConverter
{
    class Calculator
    {
        //create variables to perform calculations

        double numOne;
        double numTwo;
        double numThree;

        double total;
        double average;
        double high;
        double low;

        //create a constructor that inherits the three numbers
        public Calculator(double one, double two, double three)
        {
            //assign each number in parameter to class variable

            numOne = one;
            numTwo = two;
            numThree = three;
        }

        //create a function to calculate the total
        public double calTotal()
        {
          total = numOne + numTwo + numThree;

            return total;
        }

        //create a function to calculate the average
        public double calAverage()
        {
            average = total/3;

            return average;
        }

        //this function determines which number is the highest
        public double calHigh()
        {

            if (numOne > numTwo && numOne > numThree)
            {
                high = numOne;
                return high;
            }
            else if (numTwo > numOne && numTwo > numThree)
            {

                high = numTwo;
            }
            else
            {

                high = numThree;
            }

            return high;
        }

        //This function determine which number is the lowest
        public double calLow()
        {
            if (numOne < numTwo && numOne < numThree)
            {
                low = numOne;
            }
            else if (numTwo < numOne && numTwo < numThree)
            {

                low = numTwo;
            }
            else
            {

                low = numThree;
            }

            return low;
        }

        //this function is used to display the the different calculations from methods above
        public void displayCal()
        {
            Console.WriteLine("Total: " + total);

            Console.WriteLine();

            Console.WriteLine("Average: " + average);

            Console.WriteLine();

            Console.WriteLine("High: " + high);

            Console.WriteLine();

            Console.WriteLine("Low: " + low);

            Console.WriteLine();
        }
    }
}
