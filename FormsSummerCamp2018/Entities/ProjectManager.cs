using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ProjectManager : IEngineer
    {
        public string Email { get; set; }
        public int Age { get; set; }

        public bool ImputeWork()
        {
            throw new NotImplementedException();
        }
    }
}
