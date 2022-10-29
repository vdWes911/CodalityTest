using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace CodalityTest
{
    public class Solution
    {

        public int solution(int N, int K)
        {
            var valueAsString = Convert.ToString(N);
            int maxIncrementedValue = IncrementValues(valueAsString, K);
            return maxIncrementedValue;
        }

        private int IncrementValues(string values, int totalIncrements)
        {
            // Might be better to use a weighted counter approach for speed and avoid memory allocation for strings
            int firstDigit = Convert.ToInt32(values[0].ToString());
            int secondDigit = Convert.ToInt32(values[1].ToString());
            int thirdDigit = Convert.ToInt32(values[2].ToString());

            // Try increment first as far as possible
            var totalNumberFirstIncrementsPossible = (9 - firstDigit);
            if (totalNumberFirstIncrementsPossible > 0)
            {
                var actualIncrease = totalNumberFirstIncrementsPossible > totalIncrements ? totalIncrements : totalNumberFirstIncrementsPossible;
                firstDigit += actualIncrease;
                totalIncrements -= actualIncrease;
            }

            // Try increment second as far as possible
            var totalNumberSecondIncrementsPossible = (9 - secondDigit);
            if (totalNumberSecondIncrementsPossible > 0)
            {
                var actualIncreaseSecond = totalNumberSecondIncrementsPossible > totalIncrements ? totalIncrements : totalNumberSecondIncrementsPossible;
                secondDigit += actualIncreaseSecond;
                totalIncrements -= actualIncreaseSecond;
            }

            // Try increment second as far as possible
            var totalNumberThirdIncrementsPossible = (9 - thirdDigit);
            if (totalNumberThirdIncrementsPossible > 0)
            {
                var actualIncreaseThird = totalNumberThirdIncrementsPossible > totalIncrements ? totalIncrements : totalNumberThirdIncrementsPossible;
                thirdDigit += actualIncreaseThird;
                totalIncrements -= actualIncreaseThird;
            }

            // Do things

            var finalString = $"{firstDigit}{secondDigit}{thirdDigit}";
            return ConvertToInt(finalString);
        }

        private int ConvertToInt(string stringToConvert)
        {
            if (stringToConvert.Length > 3)
            {
                throw new ArgumentException("Number cannot be longer that 3 digits", nameof(stringToConvert));
            }
            return Convert.ToInt32(stringToConvert);
        }


        [Test]
        public void Test1()
        {
            int input = 512;
            int k = 10;
            var solutionValue = solution(input, k);
            var expectedAnswer = 972;

            Assert.That(solutionValue, Is.EqualTo(expectedAnswer));

            input = 191;
            k = 4;
            solutionValue = solution(input, k);
            expectedAnswer = 591;

            Assert.That(solutionValue, Is.EqualTo(expectedAnswer));
        }

    }
}