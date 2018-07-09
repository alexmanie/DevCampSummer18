using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica.Utils;
using Practica.Entities;
using Newtonsoft.Json;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonBudget = ReadBudgetAsync().Result;
            List<Budget> b = JsonConvert.DeserializeObject<List<Budget>>(jsonBudget);

            string jsonWork = ReadWorkAsync().Result;
            List<Work> w = JsonConvert.DeserializeObject<List<Work>>(jsonWork);

            string jsonContract = ReadContractAsync().Result;
            List<Contract> c = JsonConvert.DeserializeObject<List<Contract>>(jsonContract);

            List<Budget> superado = new List<Budget>();
            List<Budget> noSuperado = new List<Budget>();

            foreach (var budget in b)
            {
                List<Work> lw = w.Where(x => x.BudgetId == budget.BudgetId).ToList();
                var amount = 0.0;
                foreach (var work in lw)
                {
                    amount += work.AmountEur;
                }
                if (amount > budget.AmountEur)
                {
                    
                    superado.Add(budget);
                }
                else if (amount < budget.AmountEur) {
                    
                    noSuperado.Add(budget);
                }
            }
            Console.WriteLine("SUPERADO EL BUDGET");
            foreach (var s in superado)
            {
                Console.WriteLine(s.BudgetId);
            }
            Console.WriteLine("NO SUPERADO EL BUDGET");
            foreach (var s in noSuperado)
            {
                Console.WriteLine(s.BudgetId);
            }

        }

        static async Task<string> ReadBudgetAsync()
        {
            return await Utils.FileUtils.ReadBudgetAsync();
        }

        static async Task<string> ReadWorkAsync()
        {
            return await Utils.FileUtils.ReadWorkAsync();
        }

        static async Task<string> ReadContractAsync()
        {
            return await Utils.FileUtils.ReadContractAsync();
        }
    }
}


