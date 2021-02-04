using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Palindrome.Test

{
    [TestFixture]
    public class PalindromTest
    {
        Palindrome palindrome;

        [SetUp]
        public void Setup()
        {
            this.palindrome = new Palindrome();
        }
        [TestCase("ala")]
        [TestCase("łatał")]
        public void Is_Palindrome_With_Only_Letters_True(string value)
        {
            Assert.IsTrue(palindrome.IsPalindrome(value));
        }

        [TestCase("alamakota")]
        [TestCase("test")]

        public void Is_Palindrome_With_Only_Letters_False(string value)
        {
            Assert.IsFalse(palindrome.IsPalindrome(value));
        }

        [TestCase("a    l a")]
        [TestCase("a\nl\r a")]
        public void Is_Palindrome_With_Letters_And_WhiteSpaces(string value)
        {
            Assert.IsTrue(palindrome.IsPalindrome(value));
        }

        [TestCase("Ala")]
        [TestCase("aLa")]
        [TestCase("alA")]
        public void Is_Palindrome_With_Big_Letters(string value)
        {
            Assert.IsTrue(palindrome.IsPalindrome(value));
        }

        [TestCase("Kobyła ma mały bok.")]
        [TestCase("Kobyła, m, a mały bok.")]
        public void Is_Palindrome_With_Punctuation(string value)
        {
            Assert.IsTrue(palindrome.IsPalindrome(value));
        }
        [TestCase("")]
        [TestCase(" ")]
        public void Is_Palindrome_With_Empty(string value)
        {
            Assert.IsFalse(palindrome.IsPalindrome(value));
        }

    }
}
