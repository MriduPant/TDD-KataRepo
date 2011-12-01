using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TDD_Kata.FizzBuzz
    {
    [TestFixture]
    public class Runner
        {
        [TestCase(1, "1")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [Test]
        public void Run(int input, string actual)
            {
            var result = Problem.FizzBuzz(input);
            Assert.That(result, Is.EqualTo(actual));
            }
        }
    }
