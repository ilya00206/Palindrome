using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Palindrome
    {
        public bool IsPalindrome(string inputText)
        {
            if (inputText.Length < 1 || !char.IsLetter(inputText.ToCharArray()[0]))
                return false;
            
            var outputText = Regex.Replace(inputText, "[^A-Za-ząĄęĘzŻźŹćĆnŃsŚłŁóÓ]+$", "");
            outputText = Regex.Replace(outputText, @"\s+", "");
            outputText = outputText.Replace(".", "");
            outputText = outputText.Replace(",", "");
            outputText = outputText.ToLowerInvariant().Trim();
          
            
             string reverse = new string(outputText.Reverse().ToArray());
             if (outputText == reverse && outputText.Length > 0)
                 Console.WriteLine(outputText + " - is a palindrome");
             else
                 Console.WriteLine(outputText + " - is not a palindrome");

             return outputText == reverse;
        }
    }
}