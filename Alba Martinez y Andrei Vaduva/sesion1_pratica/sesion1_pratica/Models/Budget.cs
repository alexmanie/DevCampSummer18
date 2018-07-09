// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
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
        public TypeEnum Type { get; set; }

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
        public static List<Budget> FromJson(string json) => JsonConvert.DeserializeObject<List<Budget>>(json, sesion1_pratica.Models.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<Budget> self) => JsonConvert.SerializeObject(self, sesion1_pratica.Models.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                SourceConverter.Singleton,
                StatusConverter.Singleton,
                TypeEnumConverter.Singleton,
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

    internal class SourceConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Source) || t == typeof(Source?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Client":
                    return Source.Client;
                case "Internal":
                    return Source.Internal;
            }
            throw new Exception("Cannot unmarshal type Source");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Source)untypedValue;
            switch (value)
            {
                case Source.Client:
                    serializer.Serialize(writer, "Client");
                    return;
                case Source.Internal:
                    serializer.Serialize(writer, "Internal");
                    return;
            }
            throw new Exception("Cannot marshal type Source");
        }

        public static readonly SourceConverter Singleton = new SourceConverter();
    }

    internal class StatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Status) || t == typeof(Status?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Close":
                    return Status.Close;
                case "Open":
                    return Status.Open;
            }
            throw new Exception("Cannot unmarshal type Status");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Status)untypedValue;
            switch (value)
            {
                case Status.Close:
                    serializer.Serialize(writer, "Close");
                    return;
                case Status.Open:
                    serializer.Serialize(writer, "Open");
                    return;
            }
            throw new Exception("Cannot marshal type Status");
        }

        public static readonly StatusConverter Singleton = new StatusConverter();
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Account":
                    return TypeEnum.Account;
                case "Assets":
                    return TypeEnum.Assets;
                case "Fixed Project":
                    return TypeEnum.FixedProject;
                case "Project":
                    return TypeEnum.Project;
                case "Team":
                    return TypeEnum.Team;
                case "Team Work":
                    return TypeEnum.TeamWork;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            switch (value)
            {
                case TypeEnum.Account:
                    serializer.Serialize(writer, "Account");
                    return;
                case TypeEnum.Assets:
                    serializer.Serialize(writer, "Assets");
                    return;
                case TypeEnum.FixedProject:
                    serializer.Serialize(writer, "Fixed Project");
                    return;
                case TypeEnum.Project:
                    serializer.Serialize(writer, "Project");
                    return;
                case TypeEnum.Team:
                    serializer.Serialize(writer, "Team");
                    return;
                case TypeEnum.TeamWork:
                    serializer.Serialize(writer, "Team Work");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }
}
