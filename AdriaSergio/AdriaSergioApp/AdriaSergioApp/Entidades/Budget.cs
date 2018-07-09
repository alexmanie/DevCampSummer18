using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaSergioApp.Entidades
{
    public partial class Budget
    {
        [JsonProperty("BudgetId")]
        public string BudgetId { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("Amount")]
        public string Amount { get; set; }

        [JsonProperty("AmountEUR")]
        public string AmountEur { get; set; }

        [JsonProperty("Dedication")]
        public string Dedication { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("Owner")]
        public string Owner { get; set; }

        [JsonProperty("Account")]
        public string Account { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Source")]
        public string Source { get; set; }

        [JsonProperty("OpenDate")]
        public DateTimeOffset OpenDate { get; set; }

        [JsonProperty("Year")]
        public long Year { get; set; }

        [JsonProperty("Month")]
        public long Month { get; set; }

        [JsonProperty("DateKey")]
        public long DateKey { get; set; }
    }

    public partial class Budget
    {
        public static List<Budget> FromJson(string json) => JsonConvert.DeserializeObject<List<Budget>>(json, AdriaSergioApp.Entidades.Converter.Settings);
    }
}
