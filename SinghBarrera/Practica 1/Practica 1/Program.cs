using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work;
using Budget;
using Contract;
using System.IO;
using System.Reflection;



namespace Practica_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var 
        }
    }

    public class ReadFromFile
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


    }
}