using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            //handle the null
            if (vals == null)
            {
                return false;
            }

            //loops to find any "false" values
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }

            return false;

        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            //handle the null
            if (numbers == null)
            {
                return false;
            }

            var sum = 0;

            foreach (int num in numbers)
            {
                if ((num % 2) != 0)
                {
                    sum += num;
                }
            }

            return sum % 2 != 0 ? true : false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var upper = false;
            var lower = false;
            var number = false;

            foreach (char c in password)
            {
                if (Char.IsUpper(c))
                {
                    upper = true;
                    if (upper == true)
                    {
                        break;
                    }
                }
            }
            foreach (char c in password)
            {
                if (Char.IsLower(c))
                {
                    lower = true;

                    if (lower == true)
                    {
                        break;
                    }

                }
            }

            foreach (char c in password)
            {
                if (Char.IsNumber(c))
                {
                    number = true;

                    if (number == true)
                    {
                        break;
                    }
                }
            }

            if (upper == true && lower == true && number == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            var endNum = val.Length - 1;
            return val[endNum];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return divisor;
            }
            else
            {
                return dividend / divisor;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            var endNum = nums.Length - 1;
            return (nums[endNum]) - (nums[0]);
        }

        public int[] GetOddsBelow100()
        {
            var numList = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    numList.Add(i);
                }
            }

            return numList.ToArray();

        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
