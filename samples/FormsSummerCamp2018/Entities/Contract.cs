// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using FormsSummerCamp2018.Entities;
//
//    var contract = Contract.FromJson(jsonString);

namespace FormsSummerCamp2018.Entities
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Contract
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
        public object ProjectType { get; set; }

        [JsonProperty("Revenue")]
        public string Revenue { get; set; }

        [JsonProperty("RevenueEUR")]
        public string RevenueEur { get; set; }
    }

    public partial class Contract
    {
        public static List<Contract> FromJson(string json) => JsonConvert.DeserializeObject<List<Contract>>(json, FormsSummerCamp2018.Utils.Converter.Settings);
    }
}
