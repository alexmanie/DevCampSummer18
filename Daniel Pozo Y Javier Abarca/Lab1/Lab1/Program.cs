using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var BUDGETDATAPATH = "Lab1.Data.BudgetData.json";
            var CONTRACTSDATAPATH = "Lab1.Data.ContractsData.json";
            var WORKDATAPATH = "Lab1.Data.WorkData.json";


            showMenu();
        }

        private static void showMenu()
        {
            Console.WriteLine("Selecciona una opción: \n 1) Detectar wors superiores al Budget \n 2) Detectar works inferiores al Budget");
            var option = Console.Read();
            switch (option)
            {
                case 1:
                    try
                    {
                        BudgetAnomaliesDetector('>');
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Se ha encontrado una excepción: \n" + e);
                    }
                    break;
                case 2:
                    try {
                        BudgetAnomaliesDetector('<');
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Se ha encontrado una excepción: \n" + e);
                    }
                    
                    break;
                default:
                    Console.WriteLine("\n\nOPCION NO VALIDA\n\n");
                    showMenu();
                    break;
            }
        }

        private static void BudgetAnomaliesDetector(char direction)
        {
            
        }
    }
}
