using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaSergioApp.Entidades
{public partial class Work
    {
        [JsonProperty("WorkId")]
        public long WorkId { get; set; }

        [JsonProperty("EmployeeID")]
        public string EmployeeId { get; set; }

        [JsonProperty("EmployeeUnit")]
        public string EmployeeUnit { get; set; }

        [JsonProperty("BudgetId")]
        public string BudgetId { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("AmountEUR")]
        public double AmountEur { get; set; }

        [JsonProperty("Dedication")]
        public long Dedication { get; set; }

        [JsonProperty("Year")]
        public long Year { get; set; }

        [JsonProperty("Month")]
        public long Month { get; set; }
    }

    public partial class Work
    {
        public static List<Work> FromJson(string json) => JsonConvert.DeserializeObject<List<Work>>(json, AdriaSergioApp.Entidades.Converter.Settings);
   } 
}
