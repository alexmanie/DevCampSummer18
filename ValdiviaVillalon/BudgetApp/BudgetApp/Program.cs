using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetApp.Utils;

using System.IO;
using System.Reflection;
using BudgetApp.Entities;

namespace BudgetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //object data = Utils.Files.ReadSampleDataAsObject();

            object data2 = Utils.Files.ReadSampleData();
           // var sampleData1 = Work.FromJson(data2.ToString());
            var sampleData2 = Budget.FromJson(data2.ToString());
            //var sampleData3 = Contact.FromJson(data2.ToString());
            foreach (var element in sampleData2)
            {
                Console.WriteLine($"Descripcion: {element.Description}");
            }

            //Console.WriteLine(sampleData.BudgetId.ToString());
        }
    }
}
