using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raona1
{
    class Project
    {
        public Budget budget { get; set; }
        public Contract contract { get; set; }
        public List<Work> workList { get; set; }

        public Project() {
        }

        private float AmountUsed() {
            float total = 0;
            foreach (var w in workList)
            {
                total += (float)w.AmountEur;
            }
            return total;
        }

        public Boolean IsBudgetUseBelow() {
            float budgetAmount = float.Parse(budget.AmountEur);
            return AmountUsed()>budgetAmount;
        }
        public Boolean IsBudgetUseUnder() {
            float budgetAmount = float.Parse(budget.AmountEur);
            return AmountUsed() > budgetAmount;
        }
    }
}
