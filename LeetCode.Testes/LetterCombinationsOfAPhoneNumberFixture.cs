using FluentAssertions;
using RandomProblems;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests
{
    public class LetterCombinationsOfAPhoneNumberFixture
    {
        [Fact]
        public static void If_input_digit_string_is_22()
        {
            LetterCombinationsOfAPhoneNumber obj = new LetterCombinationsOfAPhoneNumber();
            obj.Run("23").Should().Equal(new List<string> { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" });

            obj.Run("4563453453").Should().HaveCount(59049);

        }
    }
}
