// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using FormsSummerCamp2018.Entities;
//
//    var demo = Budget.FromJson(jsonString);

namespace FormsSummerCamp2018.Entities
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using FormsSummerCamp2018.Utils;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Budget
    {
        [JsonProperty("BudgetId")]
        public string BudgetId { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("Amount")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public string Amount { get; set; }

        [JsonProperty("AmountEUR")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public string AmountEur { get; set; }

        [JsonProperty("Dedication")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public string Dedication { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("Owner")]
        public string Owner { get; set; }

        [JsonProperty("Account")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Account { get; set; }

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
        public static List<Budget> FromJson(string json) => JsonConvert.DeserializeObject<List<Budget>>(json, FormsSummerCamp2018.Utils.Converter.Settings);
    }    
}

