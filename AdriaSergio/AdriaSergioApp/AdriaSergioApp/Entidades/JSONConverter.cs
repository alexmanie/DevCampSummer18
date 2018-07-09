// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using AdriaSergioApp.Entidades;
//
//    var contracts = Contracts.FromJson(jsonString);

namespace AdriaSergioApp.Entidades
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class JSONConverter
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

    public partial class JSONConverter
    {
        public static List<JSONConverter> FromJson(string json) => JsonConvert.DeserializeObject<List<JSONConverter>>(json, AdriaSergioApp.Entidades.Converter.Settings);
    }

    //public partial class Budget
    //{
    //    [JsonProperty("BudgetId")]
    //    public string BudgetId { get; set; }

    //    [JsonProperty("Description")]
    //    public string Description { get; set; }

    //    [JsonProperty("Amount")]
    //    [JsonConverter(typeof(ParseStringConverter))]
    //    public long Amount { get; set; }

    //    [JsonProperty("AmountEUR")]
    //    [JsonConverter(typeof(ParseStringConverter))]
    //    public long AmountEur { get; set; }

    //    [JsonProperty("Dedication")]
    //    [JsonConverter(typeof(ParseStringConverter))]
    //    public long Dedication { get; set; }

    //    [JsonProperty("Status")]
    //    public string Status { get; set; }

    //    [JsonProperty("Owner")]
    //    public string Owner { get; set; }

    //    [JsonProperty("Account")]
    //    [JsonConverter(typeof(ParseStringConverter))]
    //    public long Account { get; set; }

    //    [JsonProperty("Type")]
    //    public string Type { get; set; }

    //    [JsonProperty("Source")]
    //    public string Source { get; set; }

    //    [JsonProperty("OpenDate")]
    //    public DateTimeOffset OpenDate { get; set; }

    //    [JsonProperty("Year")]
    //    public long Year { get; set; }

    //    [JsonProperty("Month")]
    //    public long Month { get; set; }

    //    [JsonProperty("DateKey")]
    //    public long DateKey { get; set; }
    //}

    //public partial class Budget
    //{
    //    public static List<Budget> FromJson(string json) => JsonConvert.DeserializeObject<List<Budget>>(json, AdriaSergioApp.Entidades.Converter.Settings);
    //}

    public static class Serialize
    {
        public static string ToJson(this List<JSONConverter> self) => JsonConvert.SerializeObject(self, AdriaSergioApp.Entidades.Converter.Settings);
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

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
