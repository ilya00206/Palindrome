using System;

namespace Palindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj tekst: ");
            var input = Console.ReadLine();
            var checker = new Palindrome();
            checker.IsPalindrome(input);
        }
    }
}
