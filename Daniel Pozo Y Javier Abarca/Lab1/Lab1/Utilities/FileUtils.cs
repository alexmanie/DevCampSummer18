using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Utilities
{
    class FileUtils
    {
        public static object ReadData(string filetoread)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = filetoread;

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    var sampleDataText = reader.ReadToEnd();

                    return sampleDataText;
                }
            }
        }

        public static string ReadSampleData(string filetoread)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = filetoread;

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    var sampleDataText = reader.ReadToEnd();

                    return sampleDataText;
                }
            }
        }

        public static async Task<string> ReadSampleDataAsync(string filetoread)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = filetoread;

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    var sampleDataText = await reader.ReadToEndAsync();

                    return sampleDataText;
                }
            }
        }

    }
}
