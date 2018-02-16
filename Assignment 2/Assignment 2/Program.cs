using System;

namespace Assignment_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "John Smith";
            string address = "101 N. Main Street";
            string city = "Anytown";
            string state = "TX";
            string zipCode = "11111";
            int numberUnitsTaken = 18;
            const int CostPerUnit = 100;
            int tuitionOwed;

            tuitionOwed = numberUnitsTaken * CostPerUnit;

            Console.WriteLine("Name: "+ name);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("City: " + city);
            Console.WriteLine("State: " + state);
            Console.WriteLine("Zipcode: " + zipCode);
            Convert.ToString(tuitionOwed);
            Console.WriteLine(String.Format("The tuition you owe is {0:C} " , tuitionOwed));
        }
    }
}
