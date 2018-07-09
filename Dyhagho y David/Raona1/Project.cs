using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raona1
{
    class Project
    {
        private Budget budget;
        private Contract contract;
        private Work work;

        public Project(Budget b, Contract c, Work w)
        {
            this.budget = b;
            this.contract = c;
            this.work = w;
        }
    }
}
