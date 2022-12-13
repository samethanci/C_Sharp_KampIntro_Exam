using System;

namespace _3_Day_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int number1 = 10;
            //int number2 = 20;
            //Console.WriteLine(Total(number1, number2));
            //Console.WriteLine($"Number1: {number1} Number2: {number2} Toplam: {number1 + number2}");

            /*
            // Ref
            int number1 = 10;
            int number2 = 20;
            Console.WriteLine(Total(number1, ref number2));
            Console.WriteLine($"Number1: {number1} Number2: {number2} Toplam: {number1 + number2}");*/

            /*
            // Out
            int number1;
            int number2 = 30;
            Console.WriteLine(Total(out number1, number2));
            Console.WriteLine($"Number1: {number1} Number2: {number2} Toplam: {number1 + number2}");
            */
        }

        /*
        // Ref
        static int Total(int number1, ref int number2) 
        {
            number2 = 30;
            return number1 + number2;
        }*/


        /*
        // Out
        static int Total(out int number1, int number2)
        {
            number1 = 0;
            return number1 + number2;
        }*/

    }
}
