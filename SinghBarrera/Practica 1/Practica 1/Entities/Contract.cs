// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Contract;
//
//    var welcome = Welcome.FromJson(jsonString);

namespace Practica_1.Entities
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Practica_1.Utils;

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
        [JsonConverter(typeof(ParseStringConverter))]
        public long Revenue { get; set; }

        [JsonProperty("RevenueEUR")]
        public string RevenueEur { get; set; }
    }

    public partial class Contract
    {
        public static List<Contract> FromJson(string json) => JsonConvert.DeserializeObject<List<Contract>>(json, Converter.Settings);
    }

    
}
