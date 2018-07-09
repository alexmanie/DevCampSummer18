using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace Practica.Utils
{
    public static class FileUtils
    {
        public static object ReadSampleDataAsObject()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "FormsSummerCamp2018.Data.SampleData.json";

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
            var resourceName = "FormsSummerCamp2018.Data.SampleData.json";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    var sampleDataText = reader.ReadToEnd();

                    return sampleDataText;
                }
            }
        }

        public static async Task<string> ReadBudgetAsync()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "Practica.Data.BudgetData.json";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    var sampleDataText = await reader.ReadToEndAsync();

                    return sampleDataText;
                }
            }
        }

        public static async Task<string> ReadWorkAsync()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "Practica.Data.WorkData.json";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    var sampleDataText = await reader.ReadToEndAsync();

                    return sampleDataText;
                }
            }
        }

        public static async Task<string> ReadContractAsync()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "Practica.Data.ContractsData.json";

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
