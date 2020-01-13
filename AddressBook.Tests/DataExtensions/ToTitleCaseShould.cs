using AddressBook.DataExtensionMethods;
using Xunit;

namespace AddressBook.Tests.DataExtensions
{
    public class ToTitleCaseShould
    {
        [Fact]
        public void AcceptEmptyString()
        {
            var s = string.Empty;
            var res = s.ToTitleCase();

            Assert.Equal("", res);
        }

        [Fact]
        public void WorkWithSingleChar()
        {
            const string s = "u";
            var res = s.ToTitleCase();

            Assert.Equal("U", res);
        }

        [Fact]
        public void WorkWithMoreThanOneWord()
        {
            var s = "first second third";
            var res = s.ToTitleCase();

            Assert.Equal("First Second Third", res);
        }

        [Fact]
        public void TrimAndNormalizeWhitespaces()
        {
            var s = " first   second  ";
            var res = s.ToTitleCase();

            Assert.Equal("First Second", res);
        }

        [Fact]
        public void NormalizeWeirdCasedStrings()
        {
            var s = "FIrSt sEcOnD";
            var res = s.ToTitleCase();

            Assert.Equal("First Second", res);
        }
    }
}
