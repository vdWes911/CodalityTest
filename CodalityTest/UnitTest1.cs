using System.Collections.Generic;
using System.Linq;
using System;
using NUnit.Framework;

namespace CodalityTest
{
    public class Solution
    {
        [Test]
        public void Test1()
        {
            var X = 5;
            var A = new int[] { 1, 3, 1, 4, 2, 3, 5, 4 };

            var solutionAnswer = solution(X, A);
            var answer = 6;

            Assert.That(solutionAnswer, Is.EqualTo(answer));
        }

        public int solution(int X, int[] A)
        {
            bool[] has = new bool[X];
            int count = 0;
            for (var i = 0; i < A.Length; i++)
            {
                if (has[A[i] - 1] == false)
                {
                    has[A[i] - 1] = true;
                    if (++count == X)
                        return i;
                }
            }
            return -1;
        }

    }
}