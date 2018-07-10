// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var work = Work.FromJson(jsonString);

namespace BudgetApp.Entities
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using BudgetApp.Entities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Work
    {
        [JsonProperty("WorkId")]
        public string WorkId { get; set; }

        [JsonProperty("EmployeeID")]
        public string EmployeeId { get; set; }

        [JsonProperty("EmployeeUnit")]
        public string EmployeeUnit { get; set; }

        [JsonProperty("BudgetId")]
        public string BudgetId { get; set; }

        [JsonProperty("Status")]
        public Status Status { get; set; }

        [JsonProperty("AmountEUR")]
        public double AmountEur { get; set; }

        [JsonProperty("Dedication")]
        public string Dedication { get; set; }

        [JsonProperty("Year")]
        public string Year { get; set; }

        [JsonProperty("Month")]
        public string Month { get; set; }
    }


    public partial class Work
    {
        public static List<Work> FromJson(string json) => JsonConvert.DeserializeObject<List<Work>>(json, Converter.Settings);
    }



}
