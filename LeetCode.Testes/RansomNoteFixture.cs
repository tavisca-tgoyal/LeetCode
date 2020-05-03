using FluentAssertions;
using LeetCode.Challenges.May;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests
{
    public class RansomNoteFixture
    {
        [Fact]
        public static void Running_program()
        {
            RansomNote ransomNote = new RansomNote();
            ransomNote.Run("aa","aab").Should().Be(true);
        }
    }
}
