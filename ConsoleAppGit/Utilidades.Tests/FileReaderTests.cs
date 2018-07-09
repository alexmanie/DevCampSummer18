using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Tests
{
    [TestClass()]
    public class FileReaderTests
    {
        [TestMethod()]
        public void ReadFileContentsTest()
        {
            var fileReader = new FileReader();
            string filePath = @"C:\wrk\DCS18-git\ConsoleAppGit\test.txt";
            var contents = fileReader.ReadFileContents(filePath);

            Assert.AreEqual("Hola Mundo!", contents);
        }
    }
}