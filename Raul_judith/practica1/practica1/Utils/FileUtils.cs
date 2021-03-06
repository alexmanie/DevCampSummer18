﻿using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace practica1.Utils
{
    public static class FileUtils
    {

        public static object ReadSampleDataAsObject()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "practica1.Data.BudgetData.json";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    var sampleDataText = reader.ReadToEnd();

                    return sampleDataText;
                }
            }
        }
    }
}
