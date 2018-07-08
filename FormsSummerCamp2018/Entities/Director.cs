using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Director : IEngineer, IDirector
    {
        public List<IEngineer> GetTeam()
        {
            throw new NotImplementedException();
        }

        public bool ImputeWork()
        {
            throw new NotImplementedException();
        }
    }
}
