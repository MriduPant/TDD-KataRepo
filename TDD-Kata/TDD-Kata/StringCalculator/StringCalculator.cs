using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD_Kata
    {
    public class Problem
        {


        static string[] split = new string[5];
        static char[] del = { '/', ':', ',', '\n', '.', '*', ' ' };
        static string trimChar = "\\";
        public static int Add(string numbers)
            {
            return (numbers == string.Empty ? 0 : Add1(numbers));
            }

        private static int Add1(string numbers)
            {
            return (Problem.getDelimiter(numbers) ? Add2(numbers) : (Convert.ToInt32(numbers)));
            }
        private static bool getDelimiter(string numbers)
            {
            bool find = false;
            if (numbers.Contains("-"))
                {
                ValidateInput(numbers);
                }
            else if (!(numbers.IndexOfAny(del) == -1))
                {
                find = true;
                }
            return find;
            }
        private static void ValidateInput(string numbers)
            {
            if (Convert.ToInt32(numbers) < 0)
                throw new ArgumentException(string.Format("Value cannot be Negative", numbers));
            }

        private static int Add2(string numbers)
            {
            int add = 0;
            int count = 0;
            string num = string.Empty;
            if (numbers.StartsWith(trimChar))
                {
                numbers = numbers.TrimStart(trimChar.ToCharArray());
                }
            split = numbers.Split(del);
            for (int i = 0; i < split.Length; i++)
                {
                if (split[i] == "" || Convert.ToInt32(split[i]) >= 1000)
                    {
                    numbers = Convert.ToString(0);
                    add = add + Convert.ToInt32(numbers);
                    }
                else
                    {
                    numbers = split[i];
                    add = add + Convert.ToInt32(numbers);
                    }
                }
            return add;
            }


        }
    }
