﻿using System;

namespace AreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double radius;

            double milesPerGallon;
            double milesTravelled;
            double howManyGallons;
            

            
            // Area Calculator - Welcome Message
            Console.WriteLine(">>> Area Calculator <<<");

            // get UserInput
            Console.Write("Enter a radius: ");
            input = Console.ReadLine();

            // Convert string input to double
            radius = double.Parse(input);

            // Calculate areaOfCircle     
            Console.WriteLine($"\nThe area of a circle of radius {radius} is: {Circle.getAreaOfCircle(radius)}");

            // Calculate Circumference
            Console.WriteLine($"\nThe circumference of your circle is: {Circle.getCircumference(radius)}");

            // Calculate Diameter
            Console.WriteLine($"\nThe diameter of your circle is: {Circle.getDiameter(radius)}");

            //////////////////////////////////////////////////////////////
            // Road Trip! - Welcome Message            
            Console.WriteLine("\n\n >>> Surprise Road Trip Time!!!! <<<");

            // Get MPG from User
            Console.Write("\nHow many miles-per-gallon does you car get?: ");
            input = Console.ReadLine();

            // Conver MPG from str >> dbl
            milesPerGallon = double.Parse(input);

            // Assign the area of the circle as the miles travelled by car
            milesTravelled = Circle.getAreaOfCircle(radius);

            // Find how many gallons they used to get around the circle
            howManyGallons = milesTravelled / milesPerGallon;

            Console.WriteLine($"\nYou car will used {Math.Round(howManyGallons, 4)} gallons to get around the circle.");
        }
    }

    class Circle
    {
        public const double pi = Math.PI;
        public static double getAreaOfCircle(double radius)
        {
            double areaOfCircle;
           
            areaOfCircle = pi * radius * radius;
            return areaOfCircle;
        }

        public static double getCircumference(double radius)
        {
            double circumference;
            circumference = 2 * pi * radius;
            return circumference;
        } 

        public static double getDiameter(double radius)
        {
            double diameter;
            diameter = 2 * radius;
            return diameter;
        }
        
    }
}