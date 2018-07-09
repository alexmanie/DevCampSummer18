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


