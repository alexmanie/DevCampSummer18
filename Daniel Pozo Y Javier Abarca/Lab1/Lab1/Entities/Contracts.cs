// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Lab1.Entities.Contracts;
//
//    var welcome = Welcome.FromJson(jsonString);

namespace Lab1.Entities.Contracts
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Contracts
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

    public partial class Contracs
    {
        public static Contracs FromJson(string json) => JsonConvert.DeserializeObject<Contracs>(json, Lab1.Entities.Contracts.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Contracs self) => JsonConvert.SerializeObject(self, Lab1.Entities.Contracts.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}