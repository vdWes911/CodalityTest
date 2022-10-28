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
            var frogPosition = 0;
            var second = 0;
            var expectedNextLeaf = frogPosition + 1;
            var alreadyFallenPositions = new List<int>();

            // Simulates seconds passing
            for (second = 0; second < X + 2; second++)
            {
                var fallenLeaf = A[second];
                alreadyFallenPositions.Add(fallenLeaf);

                bool canJump = fallenLeaf == expectedNextLeaf || alreadyFallenPositions.Contains(expectedNextLeaf);
                while (canJump)
                {
                    frogPosition++;
                    expectedNextLeaf = frogPosition + 1;
                    canJump = fallenLeaf == expectedNextLeaf || alreadyFallenPositions.Contains(expectedNextLeaf);
                }

                if (frogPosition == X)
                {
                    return second;
                }
            }

            return -1;
        }

    }
}