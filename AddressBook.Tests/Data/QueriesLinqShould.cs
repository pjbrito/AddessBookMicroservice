using AddressBook.ApiModels;
using AddressBook.Data;
using AddressBook.StaticDataFile;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace AddressBook.Tests.Data
{
    public class QueriesLinqShould
    {
        private readonly IAddressesDataLoader loader = null;
        private readonly List<AddressGroup> groupedSet = null;

        public QueriesLinqShould()
        {
            loader = new AddressesStaticDataFileLoader();
            groupedSet = QueriesLinq.GroupAddressesBy((Address x) => x.City, loader)
                .ToList();
        }

        [Fact]
        public void GetNonEmptyGroupedResultSet()
        {
            Assert.NotEmpty(groupedSet);
        }


        [Fact]
        public void ContainThreeAddressGroups()
        {
            Assert.Equal(3, groupedSet.Count);
        }

        [Fact]
        public void ContainThreeAddressesOnTheLondonGroup()
        {
            var result = groupedSet
                .Where(x => x.Key == "London")
                .SelectMany(x => x.Addresses)
                .ToList();

            Assert.Equal(3, result.Count);
        }

        [Fact]
        public void ContainTwoAddressesOnTheNewYorkGroup()
        {
            var result = groupedSet
                .Where(x => x.Key == "New York")
                .SelectMany(x => x.Addresses)
                .ToList();

            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void ContainOneAddressOnTheBostonGroup()
        {
            var result = groupedSet
                .Where(x => x.Key == "Boston")
                .SelectMany(x => x.Addresses)
                .ToList();

            Assert.Single(result);
        }


    }
}
