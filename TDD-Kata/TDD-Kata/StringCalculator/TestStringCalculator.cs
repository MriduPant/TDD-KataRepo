using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TDD_Kata
    {
    [TestFixture]
    public class Runner
        {

        [Test]
        public void Add_WhenGivenNoNumbers_ReturnsZero()
            {
            var result = Problem.Add("");

            Assert.That(result, Is.EqualTo(0));
            }

        [TestCase("1")]
        [TestCase("2")]
        [TestCase("3")]
        [TestCase("10")]
        [Test]
        public void Add_WhenGivenOneNumber_ReturnsThatNumber(string value)
            {
            var result = Problem.Add(value);
            Assert.That(result, Is.EqualTo(Convert.ToInt32(value)), "");
            }

        [TestCase("6,7", 13)]
        [TestCase("1:2", 3)]
        [TestCase("1/10", 11)]
        [TestCase("1//10", 11)]
        [TestCase("1\n2", 3)]
        [TestCase("3\n7", 10)]
        [TestCase("1000,1", 1)]
        [TestCase("1010,1", 1)]
        [Test]
        public void Add_WhenGivenTwoNumbers_AddNumbersTogether(string twoNumbers, int expected)
            {
            var result = Problem.Add(twoNumbers);
            Assert.That(result, Is.EqualTo(expected));
            }


        [TestCase("1\n2\n3", 6)]
        [TestCase("1:2:3", 6)]
        [TestCase("1,2,3", 6)]
        [TestCase("1 2 3", 6)]
        [TestCase("1/2/10", 13)]
        [TestCase("1//2//10", 13)]
        [TestCase("1:2,4", 7)]
        [TestCase("1\n2:3", 6)]
        [TestCase("//1\n2:5", 8)]
        [TestCase("//:1,2:8", 11)]
        [TestCase("//***5***5,2", 12)]
        [Test]
        public void Add_WhenGivenNewLinesBetweenNumbers_TreatsNewLineAsDelimiter(string value, int expected)
            {
            var result = Problem.Add(value);
            Assert.That(result, Is.EqualTo(expected));
            }

        [TestCase("\\:\n1:3", 4)]
        [TestCase("\\:\n1,4", 5)]
        [Test]
        public void Add_WhenGivenTwoSlashesAtBeginning_UsesDelimiterAfterSlashesInsteadOfComma(string value, int expected)
            {
            var result = Problem.Add(value);
            Assert.That(result, Is.EqualTo(expected));
            }

        [Test]
        [TestCase("-1")]

        public void Add_WhenGivenNegativeNumbers_ThrowsExceptionSayingNegativesArentAllowed(string numbers)
            {
            Assert.Throws<ArgumentException>(() => Problem.Add(numbers));
            }
        }
    }
