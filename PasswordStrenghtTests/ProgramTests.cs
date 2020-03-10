using System;
using Xunit;

namespace PasswordStrenght.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void GetCorrectlyLowerCaseCount()
        {
            Assert.True(Program.GetLowerCaseCount("abcdeAB12+-") == 5);
        }

        [Fact]
        public void GetCorrectlyUpperCaseCount()
        {
            Assert.True(Program.GetUpperCaseCount("abcdeAB12+-") == 2);
        }

        [Fact]
        public void GetCorrectlyDigitsCount()
        {
            Assert.True(Program.GetDigitsCount("abcdeAB12+-") == 2);
        }

        [Fact]
        public void GetCorrectlySymbolCount()
        {
            Assert.True(Program.GetSymbolCount("abcdeAB12+-") == 2);
        }

        [Fact]
        public void ChecksForSimilarChars()
        {
            Assert.True(Program.ContainsSimilarChars("ABCDabcdI"));
        }


        [Fact]
        public void ChecksForAmbigousChars()
        {
            Assert.True(Program.ContainsSimilarChars("ABCDabcdI}"));
        }
    }
}