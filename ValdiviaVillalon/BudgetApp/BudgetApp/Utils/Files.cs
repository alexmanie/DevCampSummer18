using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Reflection;

namespace BudgetApp.Utils
{
    class Files
    {
        public static object ReadSampleDataAsObject()
        {
            var assembly = Assembly.GetExecutingAssembly();
            //var resourceName = "BudgetApp.data.WorkData.json";
            var resourceName = "BudgetApp.data.ContractsData.json";
           // var resourceName = "BudgetApp.data.BudgetData.json";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    var sampleDataText = reader.ReadToEnd();

                    return sampleDataText;
                }
            }
        }

        public static string ReadSampleData()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "BudgetApp.data.BudgetData.json";
            
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    var sampleDataText = reader.ReadToEnd();

                    return sampleDataText;
                }
            }
        }

        public static async Task<string> ReadSampleDataAsync()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "BudgetApp.data.BudgetData.json";

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
