using FluentAssertions;
using Problems.May;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests
{
    public class FirstBadVersionFixture
    {
        [Fact]
        public static void Running_program()
        {
            FirstBadVersion obj = new FirstBadVersion(new bool[] { false, false, false, true, true });
            obj.Run(5).Should().Be(4);
        }
    }
}
