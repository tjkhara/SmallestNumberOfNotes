using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestNumberOfNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallestNumberOfNotes();
        }

        /// <summary>
        /// Consider a currency system in which there are notes of seven denominations, namely, Rs. 1,2,5,10,50,100.
        /// If a sum of Rs. N is entered through the keyboard, write a program to compute the smallest number of notes that will
        /// combine to give Rs. N.
        /// </summary>
        
        static void SmallestNumberOfNotes()
        {
            int number = 0;
            int HundredNotes = 0;
            int FiftyNotes = 0;
            int TenNotes = 0;
            int FiveNotes = 0;
            int TwoNotes = 0;
            int OneNotes = 0;

            Console.WriteLine("Please enter a number");

            number = Convert.ToInt32(Console.ReadLine());

            if (number >= 100)
            {
                HundredNotes = number / 100;

                number = number - HundredNotes * 100;

            }

            if (number >= 50)
            {
                FiftyNotes = number / 50;

                number = number - FiftyNotes * 50;
            }

            if (number >= 10)

            {
                TenNotes = number / 10;

                number = number - TenNotes * 10;

            }

            if (number >= 5)

            {

                FiveNotes = number / 5;

                number = number - FiveNotes * 5;

            }

            if (number >= 2)

            {

                TwoNotes = number / 2;

                number = number - TwoNotes * 2;

            }
            if (number >= 1)

            {
                OneNotes = number / 1;
                number = number - OneNotes * 1;
            }
                
                Console.WriteLine("The number of notes used are {0} Hundred Notes, {1} Fifty Notes, {2} Ten Notes, {3} Five Notes, {4} Two Notes, {5} One Notes", HundredNotes, FiftyNotes, TenNotes, FiveNotes, TwoNotes, OneNotes);    
                 
        }
    }
}
