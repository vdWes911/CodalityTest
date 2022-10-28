using System;
using NUnit.Framework;

namespace CodalityTest
{
    public class Solution
    {
        [Test]
        public void Test1()
        {
            var valueToTest = new int[] { 3, 8, 9, 7, 6 };
            var k = 3;
            var solutionValue = solution(valueToTest, k);
            var answer = new int[] { 9, 7, 6, 3, 8 };
            Assert.That(solutionValue, Is.EqualTo(answer));

            valueToTest = new int[] { 0, 0, 0 };
            k = 1;
            solutionValue = solution(valueToTest, k);
            answer = new int[] { 0, 0, 0 };
            Assert.That(solutionValue, Is.EqualTo(answer));

            valueToTest = new int[] { 1, 2, 3, 4 };
            k = 4;
            solutionValue = solution(valueToTest, k);
            answer = new int[] { 1, 2, 3, 4 };
            Assert.That(solutionValue, Is.EqualTo(answer));
        }


        public int[] solution(int[] A, int K)
        {
            var result = A;
            for (int i = 0; i < K; i++)
            {
                result = Rotate(result);
            }

            return result;
        }

        private int[] Rotate(int[] arrayToRotate)
        {
            var result = new int[arrayToRotate.Length];
            var shiftingCounter = 1;
            for (int i = 0; i < arrayToRotate.Length; i++)
            {
                if (shiftingCounter == arrayToRotate.Length)
                {
                    shiftingCounter = 0;
                }

                result[shiftingCounter++] = arrayToRotate[i];
            }

            return result;
        }
    }
}