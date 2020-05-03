using FluentAssertions;
using Problems.May;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests
{
    public class JewelsAndStonesFixture
    {
        [Fact]
        public static void Running_program_should_find_jewels_count_in_given_string()
        {
            JewelsAndStones jewelsAndStones = new JewelsAndStones();
            jewelsAndStones.Run("aA", "aAAbbbb").Should().Be(3);
        }
    }
}
