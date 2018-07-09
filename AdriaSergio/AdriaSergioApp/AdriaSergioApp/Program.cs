using AdriaSergioApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Utils;

namespace AdriaSergioApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var stringContracts = FileUtils.ReadSampleData("AdriaSergioApp.Data.ContractsData.json");
                var stringWorks = FileUtils.ReadSampleData("AdriaSergioApp.Data.WorkData.json");
                var stringBudgets = FileUtils.ReadSampleData("AdriaSergioApp.Data.BudgetData.json");

                var contracts = Contract.FromJson(stringContracts);
                var works = Work.FromJson(stringWorks);
                var budgets = Budget.FromJson(stringBudgets);

                Console.WriteLine(contracts[0].AccountName);
                Console.WriteLine(works[0].EmployeeUnit);
                Console.WriteLine(budgets[0].Owner);
            }
            catch(System.ArgumentNullException s)
            {
                Console.WriteLine(s);
                Console.ReadKey();
            }
            catch (Newtonsoft.Json.JsonSerializationException s)
            {
                Console.WriteLine(s);
                Console.ReadKey();
            }
        }
    }
}
