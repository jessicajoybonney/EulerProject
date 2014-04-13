using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerProject
{
    public class Problem1
    {
        //crtl+r+v introduce varible
        //crtl+r+m intruduce method
        //crtl+r+r rename variable
        public static int AttemptThree_SumMultiples(List<int> multiples, int number)
        {
            return Enumerable.Range(1, number-1).Where(current => multiples.Any(mod => current%mod == 0)).Sum();
        }

        public static int AttemptTwo_SumMultiples(List<int> multiples, int below)
        {
            int sumOfMultiples = 0;

            for (int i = 0; i < below; i++)
            {
                if (multiples.Select(mult => i%mult).Any(remainder => remainder == 0))
                {
                    sumOfMultiples += i;
                }
            }

            return sumOfMultiples;
        }

        public static int AttemptOne_SumMultiples(List<int> multiples, int below)
        {
            int sumOfMultiples = 0;

            for (int i = 0; i < below; i++)
            {
                foreach (int mult in multiples)
                {
                    int remainder = i % mult;
                    if (remainder == 0)
                    {
                        sumOfMultiples += i;
                        break;
                    }
                }
            }

            return sumOfMultiples;
        }

        //recursive
        public int Factorial(int number)
        {
            if (number < 2)
                return 1;
            return Factorial(number - 1);
        }
    }
}
