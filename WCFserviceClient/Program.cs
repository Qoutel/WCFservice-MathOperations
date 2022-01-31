﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFserviceClient.ServiceReference1;

namespace WCFserviceClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatorClient client = new CalculatorClient();

            double value1 = 100.00D;
            double value2 = 15.99D;
            double result = client.Add(value1, value2);
            Console.WriteLine("Operation Add({0};{1})\t Result = {2}", value1, value2, result);

            value1 = 145.00D;
            value2 = 76.54D;
            result = client.Subtract(value1, value2);
            Console.WriteLine("Operation Subtract({0};{1})\t Result = {2}", value1, value2, result);

            value1 = 9.00D;
            value2 = 81.25D;
            result = client.Multiply(value1, value2);
            Console.WriteLine("Operation Multiply({0};{1})\t Result = {2}", value1, value2, result);

            value1 = 22.00D;
            value2 = 7.00D;
            result = client.Divide(value1, value2);
            Console.WriteLine("Operation Divide({0};{1})\t Result = {2}", value1, value2, result);

            Console.WriteLine("\nPress <Enter> to terminate the client.");
            Console.ReadLine();
            client.Close();
        }
    }
}
