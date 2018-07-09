using Newtonsoft.Json;
using sesion1_pratica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace sesion1_pratica.Controllers
{
    public class HomeController : Controller
    {

        public async Task<ActionResult> Index()
        {
            Utils u = new Utils();
            string dataText = await u.ReadJsonAsync("BudgetData.json");

            List<Budget> budgets = JsonConvert.DeserializeObject<List<Budget>>(dataText);

            foreach(var b in budgets)
            {
                Console.WriteLine(b.BudgetId);
            }
            
            return View();
        }

       
    }
}