using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;

namespace sesion1_pratica.Models
{
    public  class Utils
    {
        public  async Task<string> ReadJsonAsync(string nombre)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "sesion1_practica.App_Data." + nombre;

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    var dataText = await reader.ReadToEndAsync();
                   // List<Budget> budgets = JsonConvert.DeserializeObject<List<Budget>>(dataText);
                    return dataText;
                }
            }
        }
    }

    

}