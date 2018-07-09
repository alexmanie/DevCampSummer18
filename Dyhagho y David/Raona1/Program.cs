using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raona1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Work> workList  = FileUtils.readWorkList("Raona1.files.WorkData.json");
            List<Budget> budgetList = FileUtils.readBudgetList("Raona1.files.BudgetData.json");
            List<Contract> contractList = FileUtils.readContractList("Raona1.files.ContractsData.json");


        }
    }
}
