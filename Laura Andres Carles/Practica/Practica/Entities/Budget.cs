// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using Practica.Entities;
//
//    var budget = Budget.FromJson(jsonString);

namespace Practica.Entities
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Utils;

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
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Dedication { get; set; }

        [JsonProperty("Status")]
        public Status Status { get; set; }

        [JsonProperty("Owner")]
        public string Owner { get; set; }

        [JsonProperty("Account")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Account { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Source")]
        public Source Source { get; set; }

        [JsonProperty("OpenDate")]
        public DateTimeOffset OpenDate { get; set; }

        [JsonProperty("Year")]
        public long Year { get; set; }

        [JsonProperty("Month")]
        public long Month { get; set; }

        [JsonProperty("DateKey")]
        public long DateKey { get; set; }
    }

    public enum Source { Client, Internal };

    public enum Status { Close, Open };

    public enum TypeEnum { Account, Assets, FixedProject, Project, Team, TeamWork };

    public partial class Budget
    {
        public static List<Budget> FromJson(string json) => JsonConvert.DeserializeObject<List<Budget>>(json, Practica.Utils.Converter.Settings);
    }

    
}
