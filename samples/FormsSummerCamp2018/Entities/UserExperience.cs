using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class UserExperience : IEngineer
    {
        public string Email { get; set; }
        public int Age { get; set; }

        public string Avatar { get; set; }

        public bool ImputeWork()
        {
            throw new NotImplementedException();
        }

        public string GetAvatar()
        {
            return $"http://images.com/{Email}.jpg";
        }
    }
}
