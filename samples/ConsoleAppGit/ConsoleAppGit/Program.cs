using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace ConsoleAppGit
{
    class Program
    {
        static LogWriter _logw = null;
        public static LogWriter Log = null;

        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.PropInt = 2;
            customer.Texto = "";
            customer.FistName = "alex";

            lw = new LogWriter();
            lw.WriteLog("asdasdasd");
        }

        static List<string> Listado()
        {
            return new List<string>();
        }
    }
}
