﻿// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using sesion1_pratica.Models;
//
//    var budget = Budget.FromJson(jsonString);

namespace sesion1_pratica.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Budget
    {
        [JsonProperty("BudgetId")]
        public string BudgetId { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("Amount")]
       // [JsonConverter(typeof(ParseStringConverter))]
        public string Amount { get; set; }

        [JsonProperty("AmountEUR")]
      //  [JsonConverter(typeof(ParseStringConverter))]
        public string AmountEur { get; set; }

        [JsonProperty("Dedication")]
       // [JsonConverter(typeof(ParseStringConverter))]
        public string Dedication { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("Owner")]
        public string Owner { get; set; }

        [JsonProperty("Account")]
       // [JsonConverter(typeof(ParseStringConverter))]
        public string Account { get; set; }

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
        public static Budget FromJson(string json) => JsonConvert.DeserializeObject<Budget>(json, sesion1_pratica.Models.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Budget self) => JsonConvert.SerializeObject(self, sesion1_pratica.Models.Converter.Settings);
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

