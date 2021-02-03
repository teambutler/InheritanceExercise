﻿using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Done - Create a class Animal
            // give this class 4 members that all Animals have in common


            // Done - Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Done - Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var myBird = new Bird();

            myBird.Age = 12;
            myBird.CanFly = true;
            myBird.HeadSize = 50;
            

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var myReptile = new Reptile();

            myReptile.EatsInsects = true;
            myReptile.HasClaws = true;
            myReptile.TailColor = "brown";
        }
    }
}
