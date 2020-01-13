using AddressBook.ApiModels;
using AddressBook.Data;
using AddressBook.StaticDataFile;
using Xunit;

namespace AddressBook.Tests.Data
{
    public class QueriesLinqShould
    {
        private readonly IAddressesDataLoader loader = null;

        public QueriesLinqShould()
        {
            loader = new AddressesStaticDataFileLoader();
        }

        [Fact]
        public void GetNonEmptyGroupedResultSet()
        {
            var rSet = QueriesLinq.GroupAddressesBy((Address x) => x.City, loader);

            Assert.NotEmpty(rSet);
        }
    }
}
