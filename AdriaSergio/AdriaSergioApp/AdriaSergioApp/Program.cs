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

                foreach(Budget b in budgets)
                {
                    foreach(Work w in works)
                    {
                        if(w.BudgetId == b.BudgetId)
                        {
                            if(Double.Parse(b.AmountEur) > w.AmountEur)
                            {
                                Console.WriteLine(w.BudgetId + " en el work " + w.WorkId + " + BUDGET DEL PERMITIDO");
                            }
                            else if (Double.Parse(b.AmountEur) < w.AmountEur)
                            {
                                Console.WriteLine(w.BudgetId + " en el work " + w.WorkId + " - BUDGET DEL PERMITIDO");
                            }
                        }
                    }
                }
                Console.ReadKey();
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
