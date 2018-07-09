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

            List<Project> projects = new List<Project>();
            foreach (var contract in contractList)
            {
                Project p = new Project();
                p.contract = contract;
                p.budget = budgetList.Where(b => b.Account.Equals(contract.AccountId)).First();
                projects.Add(p);
            }

            foreach (var p in projects) {
                p.workList = workList.Where(w => w.BudgetId.Equals(p.budget.BudgetId)).ToList();
            }

        }
    }
}
