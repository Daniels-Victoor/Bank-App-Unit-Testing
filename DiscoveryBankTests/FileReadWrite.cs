using Core.Abstractions;
using Core.Services;
using Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DiscoveryBankTests
{

    public class FileReadWrite
    {
    public List<string> data = new List<string> { "great, beast, bread, hunger"};
        [Fact]
        public void ReadTest()
        {
            var readwrite = new FileWriteRead();
           var actual = readwrite.ReadFile(TestFileDb.path);
            Assert.NotNull(actual);

        }


        [Fact]
        public void WriteTest()
        {
            var readwrite = new FileWriteRead();
            var actual = readwrite.WriteToFile(TestFileDb.path, data);
            Assert.True(actual);

        }
    }
}
