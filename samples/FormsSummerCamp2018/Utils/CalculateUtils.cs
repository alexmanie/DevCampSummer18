using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormsSummerCamp2018.Entities;
using MoreLinq;

namespace FormsSummerCamp2018.Utils
{
    internal static class CalculateUtils
    {
        internal static List<Budget> CalculateUnderImputed(List<Budget> budgetsDataJson, List<Work> workDataJson)
        {
            return null;
        }

        /// <summary>
        /// Devuelve los Budget que han sido SOBRE imputados
        /// </summary>
        /// <param name="budgetsDataJson"></param>
        /// <param name="workDataJson"></param>
        /// <returns></returns>
        internal static List<Budget> CalculateOverImputed(List<Budget> budgetsDataJson, List<Work> workDataJson)
        {
            try
            {
                // Get distinct BudgetId
                List<string> budgetIds = budgetsDataJson
                    .DistinctBy(b => b.BudgetId)
                    .Select(b => b.BudgetId)
                    .ToList();

                List<float> sumPerBudget = new List<float>();

                //budgetIds.ForEach(bId => sumPerBudget.Add());

                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
