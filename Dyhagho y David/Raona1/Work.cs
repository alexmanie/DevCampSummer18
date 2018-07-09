// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Raona1;
//
//    var work = Work.FromJson(jsonString);

namespace Raona1
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Work
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
        public static List<Work> FromJson(string json) => JsonConvert.DeserializeObject<List<Work>>(json, Raona1.Converter.Settings);
    }

    /*public static class Serialize
    {
        public static string ToJson(this Work self) => JsonConvert.SerializeObject(self, Raona1.Converter.Settings);
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
