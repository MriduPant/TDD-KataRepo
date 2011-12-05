using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD_Kata.FizzBuzz
    {
    public class Problem
        {
        public static string FizzBuzz(int input)
            {
            return CheckCondition(input);
            }
        private static string CheckCondition(int input)
            {
            string result = string.Empty;
            if (!(TestBoth(input) || TestWithThree(input) || TestWithFive(input)))
                {
                result = input.ToString();
                }
            else if (TestBoth(input))
                {
                result = "FizzBuzz";
                }
            else if (TestWithThree(input))
                {
                result = "Fizz";
                }
            else if (TestWithFive(input))
                {
                result = "Buzz";
                }
            return result;
            }

        private static bool TestWithFive(int input)
            {
            return (input % 5 == 0);
            }

        private static bool TestWithThree(int input)
            {
            return (input % 3 == 0);
            }

        private static bool TestBoth(int input)
            {
            return (input % 3 == 0 && input % 5 == 0);
            }
        }
    }
