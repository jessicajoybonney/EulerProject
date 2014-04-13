using System.Collections.Generic;
using System.Linq;

namespace EulerProject
{
    public class Problem2
    {
        public static int SumEvenFibonacciNumbers_AttemptOne(int below)
        {
            var fibonacci = GetFibonacci(below);
            var sumOfEvenNums = SumEvenNums(fibonacci);
            return sumOfEvenNums;
        }

        private static List<int> GetFibonacci(int below)
        {
            var fibonacci = new List<int>();
            int firstNum = 1;
            int secondNum = 1;
            int nextNum = 1;

            while (secondNum <= below)
            {
                fibonacci.Add(nextNum);

                nextNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = nextNum;
            }

            return fibonacci;
        }

        private static int SumEvenNums(List<int> numbers)
        {
            return numbers.Where(num => num % 2 == 0).Sum();
        }

        public static int SumEvenFibonacciNumbers_AttemptTwo(int below)
        {
            int firstNum = 1;
            int secondNum = 1;
            int nextNum = 0;
            int total = 0;

            while (nextNum <= below)
            {
                total = nextNum % 2 == 0 ? total + nextNum : total;

                nextNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = nextNum;

                //if(nextNum <= below)
                //    total = nextNum%2 == 0 ? total + nextNum : total;
            }

            return total;
        }


    }
}
