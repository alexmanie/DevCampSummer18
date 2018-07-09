// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
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
        public AccountOwner AccountOwner { get; set; }

        [JsonProperty("ProjectType")]
        public ProjectType? ProjectType { get; set; }

        [JsonProperty("Revenue")]
        public string Revenue { get; set; }

        [JsonProperty("RevenueEUR")]
        public string RevenueEur { get; set; }
    }

    public enum AccountOwner { AdAd81, ArBa51, EsBa12, EsBa13, EsBa15, EsBa16, EsBa17, EsBa19, EsBa22, EsBa221, EsBa24, EsBa26, EsMa31, EsMa32, EsMa91, RaonaArgentinaSRL, RaonaEnginyersSL, RaonaGroup, RaonaItConsultantsLtd, RaonaMarketing, RaonaSL, RaonaSales, UkLo71 };

    public enum ProjectType { Cons, Fpp, HsO, Mgs, Ppii, Trng };

    public partial class Contract
    {
        public static List<Contract> FromJson(string json) => JsonConvert.DeserializeObject<List<Contract>>(json, Raona1.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<Contract> self) => JsonConvert.SerializeObject(self, Raona1.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                AccountOwnerConverter.Singleton,
                ProjectTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class AccountOwnerConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AccountOwner) || t == typeof(AccountOwner?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Raona Argentina S.R.L.":
                    return AccountOwner.RaonaArgentinaSRL;
                case "Raona Enginyers S.L.":
                    return AccountOwner.RaonaEnginyersSL;
                case "Raona Group":
                    return AccountOwner.RaonaGroup;
                case "Raona IT Consultants Ltd.":
                    return AccountOwner.RaonaItConsultantsLtd;
                case "Raona Marketing":
                    return AccountOwner.RaonaMarketing;
                case "Raona S.L.":
                    return AccountOwner.RaonaSL;
                case "Raona Sales":
                    return AccountOwner.RaonaSales;
                case "adAD81":
                    return AccountOwner.AdAd81;
                case "arBA51":
                    return AccountOwner.ArBa51;
                case "esBA12":
                    return AccountOwner.EsBa12;
                case "esBA13":
                    return AccountOwner.EsBa13;
                case "esBA15":
                    return AccountOwner.EsBa15;
                case "esBA16":
                    return AccountOwner.EsBa16;
                case "esBA17":
                    return AccountOwner.EsBa17;
                case "esBA19":
                    return AccountOwner.EsBa19;
                case "esBA22":
                    return AccountOwner.EsBa22;
                case "esBA221":
                    return AccountOwner.EsBa221;
                case "esBA24":
                    return AccountOwner.EsBa24;
                case "esBA26":
                    return AccountOwner.EsBa26;
                case "esMA31":
                    return AccountOwner.EsMa31;
                case "esMA32":
                    return AccountOwner.EsMa32;
                case "esMA91":
                    return AccountOwner.EsMa91;
                case "ukLO71":
                    return AccountOwner.UkLo71;
            }
            throw new Exception("Cannot unmarshal type AccountOwner");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AccountOwner)untypedValue;
            switch (value)
            {
                case AccountOwner.RaonaArgentinaSRL:
                    serializer.Serialize(writer, "Raona Argentina S.R.L.");
                    return;
                case AccountOwner.RaonaEnginyersSL:
                    serializer.Serialize(writer, "Raona Enginyers S.L.");
                    return;
                case AccountOwner.RaonaGroup:
                    serializer.Serialize(writer, "Raona Group");
                    return;
                case AccountOwner.RaonaItConsultantsLtd:
                    serializer.Serialize(writer, "Raona IT Consultants Ltd.");
                    return;
                case AccountOwner.RaonaMarketing:
                    serializer.Serialize(writer, "Raona Marketing");
                    return;
                case AccountOwner.RaonaSL:
                    serializer.Serialize(writer, "Raona S.L.");
                    return;
                case AccountOwner.RaonaSales:
                    serializer.Serialize(writer, "Raona Sales");
                    return;
                case AccountOwner.AdAd81:
                    serializer.Serialize(writer, "adAD81");
                    return;
                case AccountOwner.ArBa51:
                    serializer.Serialize(writer, "arBA51");
                    return;
                case AccountOwner.EsBa12:
                    serializer.Serialize(writer, "esBA12");
                    return;
                case AccountOwner.EsBa13:
                    serializer.Serialize(writer, "esBA13");
                    return;
                case AccountOwner.EsBa15:
                    serializer.Serialize(writer, "esBA15");
                    return;
                case AccountOwner.EsBa16:
                    serializer.Serialize(writer, "esBA16");
                    return;
                case AccountOwner.EsBa17:
                    serializer.Serialize(writer, "esBA17");
                    return;
                case AccountOwner.EsBa19:
                    serializer.Serialize(writer, "esBA19");
                    return;
                case AccountOwner.EsBa22:
                    serializer.Serialize(writer, "esBA22");
                    return;
                case AccountOwner.EsBa221:
                    serializer.Serialize(writer, "esBA221");
                    return;
                case AccountOwner.EsBa24:
                    serializer.Serialize(writer, "esBA24");
                    return;
                case AccountOwner.EsBa26:
                    serializer.Serialize(writer, "esBA26");
                    return;
                case AccountOwner.EsMa31:
                    serializer.Serialize(writer, "esMA31");
                    return;
                case AccountOwner.EsMa32:
                    serializer.Serialize(writer, "esMA32");
                    return;
                case AccountOwner.EsMa91:
                    serializer.Serialize(writer, "esMA91");
                    return;
                case AccountOwner.UkLo71:
                    serializer.Serialize(writer, "ukLO71");
                    return;
            }
            throw new Exception("Cannot marshal type AccountOwner");
        }

        public static readonly AccountOwnerConverter Singleton = new AccountOwnerConverter();
    }

    internal class ProjectTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ProjectType) || t == typeof(ProjectType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "CONS":
                    return ProjectType.Cons;
                case "FPP":
                    return ProjectType.Fpp;
                case "HS&O":
                    return ProjectType.HsO;
                case "MGS":
                    return ProjectType.Mgs;
                case "PPII":
                    return ProjectType.Ppii;
                case "TRNG":
                    return ProjectType.Trng;
            }
            throw new Exception("Cannot unmarshal type ProjectType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ProjectType)untypedValue;
            switch (value)
            {
                case ProjectType.Cons:
                    serializer.Serialize(writer, "CONS");
                    return;
                case ProjectType.Fpp:
                    serializer.Serialize(writer, "FPP");
                    return;
                case ProjectType.HsO:
                    serializer.Serialize(writer, "HS&O");
                    return;
                case ProjectType.Mgs:
                    serializer.Serialize(writer, "MGS");
                    return;
                case ProjectType.Ppii:
                    serializer.Serialize(writer, "PPII");
                    return;
                case ProjectType.Trng:
                    serializer.Serialize(writer, "TRNG");
                    return;
            }
            throw new Exception("Cannot marshal type ProjectType");
        }

        public static readonly ProjectTypeConverter Singleton = new ProjectTypeConverter();
    }
}
