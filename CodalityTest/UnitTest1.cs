using System.Linq;
using NUnit.Framework;

namespace CodalityTest
{
    public class Solution
    {
        [Test]
        public void Test1()
        {
            var input = new int[] { 2, 1, 3 };
            var s = 2;
            var solAns = solution(input, s);
            var ans = 3;

            Assert.That(solAns, Is.EqualTo(ans));
        }

        public int solution(int[] A, int S)
        {
            var totalNumberOfSolutions = 0;

            for (int i = 1; i <= A.Length; i++)
            {
                var tempArray = new int[i];

                for (int j = 0; j < tempArray.Length; j++)
                {
                    tempArray[j] = A[j];
                    var average = tempArray.Average();
                    if (average == (double)S)
                    {
                        totalNumberOfSolutions++;
                    }
                }
            }

            return totalNumberOfSolutions;
        }

    }
}