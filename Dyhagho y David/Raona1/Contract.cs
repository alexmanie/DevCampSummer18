﻿// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Raona1;
//
//    var contract = Contract.FromJson(jsonString);

namespace Raona1
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
        public static List<Contract> FromJson(string json) => JsonConvert.DeserializeObject<List<Contract>>(json, Raona1.Converter.Settings);
    }

    /*public static class Serialize
    {
        public static string ToJson(this Contract self) => JsonConvert.SerializeObject(self, Raona1.Converter.Settings);
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
    }*/
}
