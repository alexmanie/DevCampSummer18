using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Raona1
{
    public class FileUtils
    {
        public static List<Budget> readBudgetList(string resourceName) {
            
            List<Budget> b = Budget.FromJson(readData(resourceName));
            
            return b;
        }

        public static List<Contract> readContractList(string resourceName)
        {

            List<Contract> b = Contract.FromJson(readData(resourceName));

            return b;
        }

        public static List<Work> readWorkList(string resourceName)
        {

            List<Work> b = Work.FromJson(readData(resourceName));

            return b;
        }
        private static string readData(string resourceName) {
            var assembly = Assembly.GetExecutingAssembly();

            using (Stream stream = assembly.GetManifestResourceStream(resourceName)) {
                using (StreamReader reader = new StreamReader(stream))
                {
                    var data = reader.ReadToEnd();
                    return data;
                }
            }
        }
    }
}
