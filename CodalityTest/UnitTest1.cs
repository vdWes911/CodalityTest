using System;
using NUnit.Framework;

namespace CodalityTest
{
    public class Solution
    {
        [Test]
        public void Test1()
        {
            var valueToTest = 9;
            var solutionValue = solution(valueToTest);
            Assert.That(solutionValue, Is.EqualTo(2), $"Solution for value {valueToTest}, was incorrect");

            valueToTest = 529;
            solutionValue = solution(valueToTest);
            Assert.That(solutionValue, Is.EqualTo(4), $"Solution for value {valueToTest}, was incorrect");

            valueToTest = 20;
            solutionValue = solution(valueToTest);
            Assert.That(solutionValue, Is.EqualTo(1), $"Solution for value {valueToTest}, was incorrect");

            valueToTest = 15;
            solutionValue = solution(valueToTest);
            Assert.That(solutionValue, Is.EqualTo(0), $"Solution for value {valueToTest}, was incorrect");

            valueToTest = 32;
            solutionValue = solution(valueToTest);
            Assert.That(solutionValue, Is.EqualTo(0), $"Solution for value {valueToTest}, was incorrect");

        }

        public int solution(int N)
        {
            if (N < 0)
            {
                throw new ArgumentException($"The value of {nameof(N)}, must be positive", nameof(N));
            }

            // 9    =>  1001            =   2
            // 529  =>  1000010001      =   4
            var binaryValue = Convert.ToString(N, 2);

            var maxBinaryGap = -1;
            var firstMarkerSet = false;
            var firstMarkerIndex = 0;
            var secondMarkerIndex = 0;
            var hasZero = false;

            for (int i = 0; i < binaryValue.Length; i++)
            {
                var current = binaryValue[i];
                if (current == '1')
                {
                    if (firstMarkerSet == false)
                    {
                        firstMarkerIndex = i;
                        firstMarkerSet = true;
                    }
                    else
                    {
                        secondMarkerIndex = i;
                    }

                    // The second time a 1 is encountered the secondMarker should be set.
                }

                // Do not use else, when last item is a 1, the calculation should happen

                if (current == '0')
                {
                    hasZero = true;
                }

                if (i == binaryValue.Length - 1 || firstMarkerIndex != secondMarkerIndex)
                {
                    if (firstMarkerIndex == secondMarkerIndex || hasZero == false)
                    {
                        return maxBinaryGap != -1 ? maxBinaryGap : 0;
                    }

                    // The first time a 0 is detected after both markers were set, the calculation should happen
                    if (firstMarkerSet)
                    {
                        var tempGap = (secondMarkerIndex - firstMarkerIndex) - 1;
                        if (tempGap > maxBinaryGap)
                        {
                            maxBinaryGap = tempGap;
                        }

                        firstMarkerIndex = secondMarkerIndex;
                    }
                }
            }

            if (hasZero == false)
            {
                return 0;
            }

            return maxBinaryGap;
        }

    }
}

