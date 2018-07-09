using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Utils.Tests
{
    [TestClass()]
    public class FileUtilsTests
    {
        [TestMethod()]
        public async Task ReadBudgetDataAsyncTest()
        {
            try
            {
                var data = await FileUtils.ReadBudgetDataAsync();
                Assert.IsNotNull(data);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public async Task ReadContractsDataAsyncTest()
        {
            try
            {
                var data = await FileUtils.ReadContractsDataAsync();
                Assert.IsNotNull(data);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public async Task ReadWorkDataAsyncTest()
        {
            try
            {
                var data = await FileUtils.ReadWorkDataAsync();
                Assert.IsNotNull(data);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}