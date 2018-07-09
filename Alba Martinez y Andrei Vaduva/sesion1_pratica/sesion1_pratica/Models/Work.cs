// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using sesion1_pratica.Models;
//
//    var work = Work.FromJson(jsonString);

namespace sesion1_pratica.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Work
    {
       /* [JsonProperty("WorkId")]
        public long WorkId { get; set; }

        [JsonProperty("EmployeeID")]
        public string EmployeeId { get; set; }

        [JsonProperty("EmployeeUnit")]
        public EmployeeUnit EmployeeUnit { get; set; }

        [JsonProperty("BudgetId")]
        public string BudgetId { get; set; }

        [JsonProperty("Status")]
        public Status Status { get; set; }

        [JsonProperty("AmountEUR")]
        public double AmountEur { get; set; }

        [JsonProperty("Dedication")]
        public long Dedication { get; set; }

        [JsonProperty("Year")]
        public long Year { get; set; }

        [JsonProperty("Month")]
        public long Month { get; set; }
    }

    public enum EmployeeUnit { AdAd81, ArBa51, ArSl61, Es10, EsBa12, EsBa13, EsBa15, EsBa16, EsBa17, EsBa18, EsBa19, EsBa21, EsBa22, EsBa221, EsBa23, EsBa24, EsBa241, EsBa242, EsBa243, EsBa244, EsBa25, EsBa26, EsBa261, EsBa262, EsBa27, EsBa28, EsBa29, EsBack, EsMa31, EsMa32, EsMa33, EsMa34, EsMa35, EsMa39, EsMa91, EsMa92, EsMa93, EsMa94, EsMa96, UkLo71 };

    public enum Status { Close, Open };

    public partial class Work
    {
        public static List<Work> FromJson(string json) => JsonConvert.DeserializeObject<List<Work>>(json, sesion1_pratica.Models.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<Work> self) => JsonConvert.SerializeObject(self, sesion1_pratica.Models.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                EmployeeUnitConverter.Singleton,
                StatusConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class EmployeeUnitConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EmployeeUnit) || t == typeof(EmployeeUnit?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "ES_10":
                    return EmployeeUnit.Es10;
                case "adAD81":
                    return EmployeeUnit.AdAd81;
                case "arBA51":
                    return EmployeeUnit.ArBa51;
                case "arSL61":
                    return EmployeeUnit.ArSl61;
                case "esBA12":
                    return EmployeeUnit.EsBa12;
                case "esBA13":
                    return EmployeeUnit.EsBa13;
                case "esBA15":
                    return EmployeeUnit.EsBa15;
                case "esBA16":
                    return EmployeeUnit.EsBa16;
                case "esBA17":
                    return EmployeeUnit.EsBa17;
                case "esBA18":
                    return EmployeeUnit.EsBa18;
                case "esBA19":
                    return EmployeeUnit.EsBa19;
                case "esBA21":
                    return EmployeeUnit.EsBa21;
                case "esBA22":
                    return EmployeeUnit.EsBa22;
                case "esBA221":
                    return EmployeeUnit.EsBa221;
                case "esBA23":
                    return EmployeeUnit.EsBa23;
                case "esBA24":
                    return EmployeeUnit.EsBa24;
                case "esBA241":
                    return EmployeeUnit.EsBa241;
                case "esBA242":
                    return EmployeeUnit.EsBa242;
                case "esBA243":
                    return EmployeeUnit.EsBa243;
                case "esBA244":
                    return EmployeeUnit.EsBa244;
                case "esBA25":
                    return EmployeeUnit.EsBa25;
                case "esBA26":
                    return EmployeeUnit.EsBa26;
                case "esBA261":
                    return EmployeeUnit.EsBa261;
                case "esBA262":
                    return EmployeeUnit.EsBa262;
                case "esBA27":
                    return EmployeeUnit.EsBa27;
                case "esBA28":
                    return EmployeeUnit.EsBa28;
                case "esBA29":
                    return EmployeeUnit.EsBa29;
                case "esBACK":
                    return EmployeeUnit.EsBack;
                case "esMA31":
                    return EmployeeUnit.EsMa31;
                case "esMA32":
                    return EmployeeUnit.EsMa32;
                case "esMA33":
                    return EmployeeUnit.EsMa33;
                case "esMA34":
                    return EmployeeUnit.EsMa34;
                case "esMA35":
                    return EmployeeUnit.EsMa35;
                case "esMA39":
                    return EmployeeUnit.EsMa39;
                case "esMA91":
                    return EmployeeUnit.EsMa91;
                case "esMA92":
                    return EmployeeUnit.EsMa92;
                case "esMA93":
                    return EmployeeUnit.EsMa93;
                case "esMA94":
                    return EmployeeUnit.EsMa94;
                case "esMA96":
                    return EmployeeUnit.EsMa96;
                case "ukLO71":
                    return EmployeeUnit.UkLo71;
            }
            throw new Exception("Cannot unmarshal type EmployeeUnit");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EmployeeUnit)untypedValue;
            switch (value)
            {
                case EmployeeUnit.Es10:
                    serializer.Serialize(writer, "ES_10");
                    return;
                case EmployeeUnit.AdAd81:
                    serializer.Serialize(writer, "adAD81");
                    return;
                case EmployeeUnit.ArBa51:
                    serializer.Serialize(writer, "arBA51");
                    return;
                case EmployeeUnit.ArSl61:
                    serializer.Serialize(writer, "arSL61");
                    return;
                case EmployeeUnit.EsBa12:
                    serializer.Serialize(writer, "esBA12");
                    return;
                case EmployeeUnit.EsBa13:
                    serializer.Serialize(writer, "esBA13");
                    return;
                case EmployeeUnit.EsBa15:
                    serializer.Serialize(writer, "esBA15");
                    return;
                case EmployeeUnit.EsBa16:
                    serializer.Serialize(writer, "esBA16");
                    return;
                case EmployeeUnit.EsBa17:
                    serializer.Serialize(writer, "esBA17");
                    return;
                case EmployeeUnit.EsBa18:
                    serializer.Serialize(writer, "esBA18");
                    return;
                case EmployeeUnit.EsBa19:
                    serializer.Serialize(writer, "esBA19");
                    return;
                case EmployeeUnit.EsBa21:
                    serializer.Serialize(writer, "esBA21");
                    return;
                case EmployeeUnit.EsBa22:
                    serializer.Serialize(writer, "esBA22");
                    return;
                case EmployeeUnit.EsBa221:
                    serializer.Serialize(writer, "esBA221");
                    return;
                case EmployeeUnit.EsBa23:
                    serializer.Serialize(writer, "esBA23");
                    return;
                case EmployeeUnit.EsBa24:
                    serializer.Serialize(writer, "esBA24");
                    return;
                case EmployeeUnit.EsBa241:
                    serializer.Serialize(writer, "esBA241");
                    return;
                case EmployeeUnit.EsBa242:
                    serializer.Serialize(writer, "esBA242");
                    return;
                case EmployeeUnit.EsBa243:
                    serializer.Serialize(writer, "esBA243");
                    return;
                case EmployeeUnit.EsBa244:
                    serializer.Serialize(writer, "esBA244");
                    return;
                case EmployeeUnit.EsBa25:
                    serializer.Serialize(writer, "esBA25");
                    return;
                case EmployeeUnit.EsBa26:
                    serializer.Serialize(writer, "esBA26");
                    return;
                case EmployeeUnit.EsBa261:
                    serializer.Serialize(writer, "esBA261");
                    return;
                case EmployeeUnit.EsBa262:
                    serializer.Serialize(writer, "esBA262");
                    return;
                case EmployeeUnit.EsBa27:
                    serializer.Serialize(writer, "esBA27");
                    return;
                case EmployeeUnit.EsBa28:
                    serializer.Serialize(writer, "esBA28");
                    return;
                case EmployeeUnit.EsBa29:
                    serializer.Serialize(writer, "esBA29");
                    return;
                case EmployeeUnit.EsBack:
                    serializer.Serialize(writer, "esBACK");
                    return;
                case EmployeeUnit.EsMa31:
                    serializer.Serialize(writer, "esMA31");
                    return;
                case EmployeeUnit.EsMa32:
                    serializer.Serialize(writer, "esMA32");
                    return;
                case EmployeeUnit.EsMa33:
                    serializer.Serialize(writer, "esMA33");
                    return;
                case EmployeeUnit.EsMa34:
                    serializer.Serialize(writer, "esMA34");
                    return;
                case EmployeeUnit.EsMa35:
                    serializer.Serialize(writer, "esMA35");
                    return;
                case EmployeeUnit.EsMa39:
                    serializer.Serialize(writer, "esMA39");
                    return;
                case EmployeeUnit.EsMa91:
                    serializer.Serialize(writer, "esMA91");
                    return;
                case EmployeeUnit.EsMa92:
                    serializer.Serialize(writer, "esMA92");
                    return;
                case EmployeeUnit.EsMa93:
                    serializer.Serialize(writer, "esMA93");
                    return;
                case EmployeeUnit.EsMa94:
                    serializer.Serialize(writer, "esMA94");
                    return;
                case EmployeeUnit.EsMa96:
                    serializer.Serialize(writer, "esMA96");
                    return;
                case EmployeeUnit.UkLo71:
                    serializer.Serialize(writer, "ukLO71");
                    return;
            }
            throw new Exception("Cannot marshal type EmployeeUnit");
        }

        public static readonly EmployeeUnitConverter Singleton = new EmployeeUnitConverter();
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

        public static readonly StatusConverter Singleton = new StatusConverter();*/
    }
}
