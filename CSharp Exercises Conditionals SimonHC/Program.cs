using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Exercises_Conditionals_SimonHC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave01
            Console.WriteLine("Opgave01");
            Console.WriteLine(AbsouleValue(3268));
            Console.WriteLine(AbsouleValue(-392));
            //Opgave02
            Console.WriteLine("Opgave02");
            Console.WriteLine(DivisibleBy2Or3(15, 30));
            Console.WriteLine(DivisibleBy2Or3(2, 90));
            Console.WriteLine(DivisibleBy2Or3(7, 12));
            //Opgave03
            Console.WriteLine("Opgave03");
            Console.WriteLine(IfConsistOfUpperCaseLetters("xyz"));
            Console.WriteLine(IfConsistOfUpperCaseLetters("DOG"));
            Console.WriteLine(IfConsistOfUpperCaseLetters("L9#"));
            //Opgave04
            Console.WriteLine("Opgave04");
            Console.WriteLine(IfGreaterThanThirdOne(2, 7, 12));
            Console.WriteLine(IfGreaterThanThirdOne(-5, -8, 50));
            //Opgave05
            Console.WriteLine("Opgave05");
            Console.WriteLine(IfNumberIsEven(721));
            Console.WriteLine(IfNumberIsEven(1248));
            //Opgave06
            Console.WriteLine("Opgave06");
            Console.WriteLine(IfSortedAscending(new int[] { 3, 7, 10 }));
            Console.WriteLine(IfSortedAscending(new int[] { 74, 62, 99 }));
            //Opgave07
            Console.WriteLine("Opgave07");
            Console.WriteLine(PositiveNegativeOrZero(5.24));
            Console.WriteLine(PositiveNegativeOrZero(0));
            Console.WriteLine(PositiveNegativeOrZero(-994.53));
            //Opgave08
            Console.WriteLine("Opgave08");
            Console.WriteLine(IfYearIsLeap(2016));
            Console.WriteLine(IfYearIsLeap(2018));
            //Skudår algoritme bekræftelse:
            //PrintLeapYears(0, 2020);
            Console.ReadLine();
        }
        static bool IfYearIsLeap(int a)
        {
            //Ud fra definitionen af et skudår skal året være deleligt med 4, men ikke med 100. Dog må året gerne være deleligt med 400.
            //Funktionen PrintLeapYears bekræfter algoritmens validitet.
            if(a % 4 == 0 && (a % 100 != 0 || a % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void PrintLeapYears(int startÅr, int slutÅr)
        {
            for (int i = startÅr; i <= slutÅr; i++)
            {
                if (i % 4 == 0 && (i % 100 != 0 || i % 400 == 0))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static string PositiveNegativeOrZero(double a)
        {
            //Det eneste tilfælde hvor a kan være nul er hvis a hverken er større end eller mindre end 0
            if(a > 0)
            {
                return "Positive";
            }
            else if(a < 0)
            {
                return "negative";
            }
            else
            {
                return "zero";
            }
        }
        static bool IfSortedAscending(int[] a)
        {
            //der loopes igennem a
            for (int i = 0; i < a.Length-1; i++)
            {
                //er der et eneste tilfælde hvor indexet af den nuværende iteration er større end den næste, kan den ikke være sorteret stigende.
                if(a[i] > a[i+1])
                {
                    return false;
                }
            }
            return true;
        }
        static bool IfNumberIsEven(int a)
        {
            //Hvis a er lige kan a deles ligeligt med 2.
            return a % 2 == 0;
        }
        static bool IfGreaterThanThirdOne(int a, int b, int c)
        {
            //Hvis summen eller produktet af a og b er større end c returneres der sand, ellers falsk.
            return (a + b > c) || (a * b > c);
        }
        static bool IfConsistOfUpperCaseLetters(string a)
        {
            //der laves en streng med værdier der kan holdes op imod a.
            string lowerCaseLetters = "abcdefghijklmnopqrstuvwxyzæøå123456789!@£#¤$%€&/{([)]=}?+´`|¨~^*'-_.,;:";
            for (int i = 0; i < a.Length; i++)
            {
                //for hver karakter i a holdes denne karakter op imod en værdi i lowercaseletters
                for (int j = 0; j < lowerCaseLetters.Length; j++)
                {
                    //såfremt der er et match, består a ikke kun af store bogstaver.
                    if(a[i] == lowerCaseLetters[j])
                    {
                        return false;
                    }
                }
            }
            //Hvis den aldrig finder et match i ovenstående loop betyder det at strengen kun 
            //består af store bogstaver og eventuelt et eller symbol(er) jeg har glemt at holde a's karaktere op imod.
            return true;
        }
        static int DivisibleBy2Or3(int a, int b)
        {
            //Såfremt 2 eller 3 går op i a og 2 eller 3 går op i b, returneres deres produkt, ellers returneres deres sum.
            if((a % 2 == 0 || a % 3 == 0) && (b % 2 == 0 || b % 3 == 0))
            {
                return a * b;
            }
            else
            {
                return a + b;
            }
        }
        static int AbsouleValue(int a)
        {
            //den absolutte værdi af et negativt tal ligger modsat det negative tal på tallinjen. 
            //Såfremt a er negativ ganges a derfor  med minus 1 for at finde den absolutte værdi.
            if(a < 0)
            {
                return a * -1;
            }
            else
            {
                return a;
            }
        }
    }
}
