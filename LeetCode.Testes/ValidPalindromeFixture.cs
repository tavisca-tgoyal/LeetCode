using FluentAssertions;
using RandomProblems;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests
{
    public class ValidPalindromeFixture
    {
        [Fact]
        public static void Run_Program()
        {
            ValidPalindrome validPalindrome = new ValidPalindrome();
            validPalindrome.Run("A man, a plan, a canal: Panama").Should().Be(true);

        }
    }
}
