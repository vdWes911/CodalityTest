using System;
using NUnit.Framework;

namespace CodalityTest
{
    public class Solution
    {
        [Test]
        public void Test1()
        {
            var x = 10;
            var y = 85;
            var d = 30;

            var solutionAnswer = solution(x, y, d);
            var answer = 3;

            Assert.That(solutionAnswer, Is.EqualTo(answer));
        }

        public int solution(int X, int Y, int D)
        {
            return (int)Math.Ceiling((Y - X) / (double)D);
        }

    }
}