using AddressBook.ApiModels;
using AddressBook.Data;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace AddressBook.StaticDataFile
{
    public class AddressesStaticDataFileLoader : IAddressesDataLoader
    {
        public IEnumerable<Address> LoadFile()
        {
            var provider = new PhysicalFileProvider(Environment.CurrentDirectory);
            var fileI = provider.GetFileInfo(@"StaticDataFile\StaticRepo.json");

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNameCaseInsensitive = true
            };

            if (!fileI.Exists)
            {
                return new List<Address>();
            }

            using var sr = new StreamReader(fileI.PhysicalPath);
            var jsonFile = sr.ReadToEnd();
            var result = JsonSerializer.Deserialize(jsonFile, typeof(List<Address>), options) as List<Address>;

            return result;
        }

        public IEnumerable<Address> GetAllAddresses()
        {
            return LoadFile();
        }
    }
}
