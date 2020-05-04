using FluentAssertions;
using LeetCode.Challenges.May;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests
{
    public class NumberComplementFixture
    {
        [Fact]
        public static void Program_should_convert_decimal_to_binary_complement_and_return_decimal()
        {
            NumberComplement numberComplement = new NumberComplement();
            numberComplement.Run(5).Should().Be(2);
            numberComplement.Run(1).Should().Be(0);
        }
    }
}
