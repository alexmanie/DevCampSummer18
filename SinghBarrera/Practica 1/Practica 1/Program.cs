using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;



namespace Practica_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Work = Practica_1.Entities.Work.FromJson(ReadFromFile.ReadSampleDataAsObject("Practica_1.Data.WorkData.json").ToString());
            var Contract = Practica_1.Entities.Contract.FromJson(ReadFromFile.ReadSampleDataAsObject("Practica_1.Data.ContractData.json").ToString());
            var Budget = Practica_1.Entities.Budget.FromJson(ReadFromFile.ReadSampleDataAsObject("Practica_1.Data.BudgetData.json").ToString());
        }

        static void ComparaDineros(List<Practica_1.Entities.Work> works, List<Practica_1.Entities.Budget> budgets, List<Practica_1.Entities.Contract> contracts)
        {
            foreach (var work in works)
            {
                work.BudgetId=budgets
            }
        }
    }

    public class ReadFromFile
    {
        public static object ReadSampleDataAsObject(string nombrePath)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = nombrePath;

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