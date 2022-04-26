using System;

namespace SyntaxAndSugar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var  answer = 4;
            //string response;

            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than nine";
            Console.WriteLine(response);




            //if (answer < 9)
            //{
            //    response = answer + " is less than nine";
            //}
            //else
            //{
            //    response = answer + " is greater than or equal to nine";
            //}
        }
    }
}
