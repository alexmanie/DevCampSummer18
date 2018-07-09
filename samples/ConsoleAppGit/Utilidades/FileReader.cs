using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class FileReader
    {
        public string ReadFileContents(string filePath)
        {
            var contents = System.IO.File.ReadAllText(filePath);
            return contents;
        }
    }
}
