﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{

            public class Customer
{
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Bank { get; set; }
}
    public static void Main()
    {
        // Find the words in the collection that start with the letter 'L'
        List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

        IEnumerable<string> LFruits = fruits.Where(fruit => fruit.StartsWith("L"));

        // Which of the following numbers are multiples of 4 or 6
        List<int> numbers = new List<int>()
     {
         15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
     };

        IEnumerable<int> fourSixMultiples = numbers.Where(number => number % 4 == 0 || number % 6 == 0);


        foreach (string fruit in LFruits)
        {
            Console.WriteLine($"{fruit} starts with an L");
        }
         foreach (int number in fourSixMultiples)
        {
            Console.WriteLine(number);
        }
        // Order these student names alphabetically, in descending order (Z to A)
        List<string> names = new List<string>()
        {
         "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
         "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
         "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
         "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
         "Francisco", "Tre"
        };

        IEnumerable<string> descending = names.OrderByDescending(n => n);

        // Build a collection of these numbers sorted in ascending order
        List<int> moreNumbers = new List<int>()
        {
         15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };
        IEnumerable<int> ascending = moreNumbers.OrderBy(n => n);

         foreach (string name in descending)
        {
            Console.WriteLine(name);
        }
        
        foreach (int number in ascending)
        {
            Console.WriteLine(number);
        }

        // Output how many numbers are in this list
        List<int> evenMoreNumbers = new List<int>()
        {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
        };

        int count = evenMoreNumbers.Count;

        // How much money have we made?
        List<double> purchases = new List<double>()
        {
            2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
        };
        double totalMonies = purchases.Sum();

        // What is our most expensive product?
        List<double> prices = new List<double>()
        {
        879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
        };

        double mostExp = prices.OrderByDescending(p => p).First();


        Console.WriteLine($"Highest price: {mostExp}");
        Console.WriteLine($"Total Monies: {totalMonies}");
        Console.WriteLine($"this is how many numbers {count}");


        List<int> wheresSquaredo = new List<int>()
        {
         66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
        };
        /*
          Store each number in the following List until a perfect square
          is detected.

         Expected output is { 66, 12, 8, 27, 82, 34, 7, 50, 19, 46 } 

         Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
        */

       int firstSquare = wheresSquaredo.First(num => Math.Sqrt(num) %1 ==0);

       int stopHere = wheresSquaredo.IndexOf(firstSquare);

       List<int> listUntilPerfSquare = wheresSquaredo.GetRange(0, stopHere);

       Console.WriteLine(string.Join(",", listUntilPerfSquare));



        List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };

            var millPerBank = customers
            .Where(c => c.Balance >= 1000000)
            .GroupBy(c => c.Bank)
            .Select(group => new
            {
                Bank = group.Key,
                Count = group.Count()
            });

            foreach (var millies in millPerBank)
            {
                Console.WriteLine($"{millies.Bank} {millies.Count}");
            }

    }
}
