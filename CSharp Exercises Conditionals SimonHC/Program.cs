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
            Console.ReadLine();
        }
        static bool IfYearIsLeap(int a)
        {
            if(a % 4 == 0 && (a % 100 != 0 || a % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static string PositiveNegativeOrZero(double a)
        {
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
            for (int i = 0; i < a.Length-1; i++)
            {
                if(a[i] > a[i+1])
                {
                    return false;
                }
            }
            return true;
        }
        static bool IfNumberIsEven(int a)
        {
            return a % 2 == 0;
        }
        static bool IfGreaterThanThirdOne(int a, int b, int c)
        {
            return (a + b > c) || (a * b > c);
        }
        static bool IfConsistOfUpperCaseLetters(string a)
        {
            string lowerCaseLetters = "abcdefghijklmnopqrstuvwxyzæøå123456789!@£#¤$%€&/{([)]=}?+´`|¨~^*'-_.,;:";
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < lowerCaseLetters.Length; j++)
                {
                    if(a[i] == lowerCaseLetters[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static int DivisibleBy2Or3(int a, int b)
        {
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
