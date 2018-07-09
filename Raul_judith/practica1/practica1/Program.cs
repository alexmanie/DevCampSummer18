using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using QuickType;
using QuickType.Entities;

namespace practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            object budgetData = Utils.FileUtils.ReadSampleDataAsObject();
            var budget = Budget.FromJson(budgetData.ToString());
            Console.WriteLine(budget.BudgetId);
            /*
            var contract = Contract.FromJson(jsonString);
            Console.WriteLine(budget.BudgetId);

            var work = Work.FromJson(WorkId.ToString());
            Console.WriteLine(work.WorkId);
            */
        }
    }
}
