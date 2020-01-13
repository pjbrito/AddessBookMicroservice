using AddressBook.StaticDataFile;
using System.Linq;
using AddressBook.Data;
using Xunit;

namespace AddressBook.Tests.StaticDataFile
{
    public class FileLoaderShould
    {
        private readonly AddressesStaticDataFileLoader loader = null;

        public FileLoaderShould()
        {
            loader = new AddressesStaticDataFileLoader();
        }

        [Fact]
        public void LoadStaticDataFile()
        {
            var data = loader.LoadFile();

            Assert.NotEmpty(data);
        }

        [Fact]
        public void LoadFirstElementCorrectly()
        {
            var data = loader.LoadFile().ToList();

            Assert.Equal("John", data[0].FirstName);
            Assert.Equal("Smith", data[0].LastName);
            Assert.Equal("Test St 1", data[0].StreetAddress);
            Assert.Equal("London", data[0].City);
            Assert.Equal("England", data[0].Country);
        }

        [Fact]
        public void LoadAddresses()
        {
            var data = loader.LoadFile();

            Assert.Equal(6, data.Count());
        }

        [Fact]
        public void LoadAllFromIAddressesDataLoader()
        {
            var i = (IAddressesDataLoader) loader;
            var data = i.GetAllAddresses();

            Assert.Equal(6, data.Count());
        }

    }
}
