using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace practica1.Utils
{
    public static class FileUtils
    {

        public static async Task<string> ReadSampleDataAsync()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "Raul_judith.Data.BudgetData.json";

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
