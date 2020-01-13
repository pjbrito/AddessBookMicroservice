using AddressBook.StaticDataFile;
using Xunit;

namespace AddressBook.Tests.StaticDataFile
{
    public class FileLoaderShould
    {
        [Fact]
        public void LoadStaticDataFile()
        {
            var l = new AddressesStaticDataFileLoader();
            var data = l.LoadFile();

            Assert.NotEmpty(data);
        }
    }
}
