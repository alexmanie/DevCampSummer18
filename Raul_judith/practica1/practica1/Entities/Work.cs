﻿// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var work = Work.FromJson(jsonString);

namespace QuickType.Entities
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
        public static Work FromJson(string json) => JsonConvert.DeserializeObject<Work>(json, practica1.Utils.Converter.Settings);
    }

   
}
