﻿using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Utils
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

        //Tots els metodes asincronos tenen "async" i retornen Task.
        //Es fica "await" on vols que esperi
        public static async Task<string> ReadSampleDataAsync()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "FormsSummerCamp2018.Data.SampleData.json";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    var sampleDataText = await reader.ReadToEndAsync();

                    return sampleDataText;
                }
            }
        }

        public static async Task<string> ReadBudgetDataAsync()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "FormsSummerCamp2018.Data.BudgetData.json";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    var sampleDataText = await reader.ReadToEndAsync();

                    return sampleDataText;
                }
            }
        }

        public static async Task<string> ReadContractsDataAsync()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "FormsSummerCamp2018.Data.ContractsData.json";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    var sampleDataText = await reader.ReadToEndAsync();

                    return sampleDataText;
                }
            }
        }

        public static async Task<string> ReadWorkDataAsync()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "FormsSummerCamp2018.Data.WorkData.json";

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
