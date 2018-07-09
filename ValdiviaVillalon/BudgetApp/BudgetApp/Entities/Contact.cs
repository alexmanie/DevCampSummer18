using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Entities
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Contact
    {
        [JsonProperty("ContractID")]
        public string ContractId { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("AccountID")]
        public long AccountId { get; set; }

        [JsonProperty("AccountName")]
        public string AccountName { get; set; }

        [JsonProperty("AccountOwner")]
        public string AccountOwner { get; set; }

        [JsonProperty("ProjectType")]
        public string ProjectType { get; set; }

        [JsonProperty("Revenue")]
        public string Revenue { get; set; }

        [JsonProperty("RevenueEUR")]
        public string RevenueEur { get; set; }
    }

    public partial class Contact
    {
        public static List<Contact> FromJson(string json) => JsonConvert.DeserializeObject<List<Contact>>(json, Converter.Settings);
    }

    

}
