using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace Raona1
{
    public static class Serialize
    {
        //public static string ToJson(this Contract self) => JsonConvert.SerializeObject(self, Raona1.Converter.Settings);
        public static string ToJson(this Contract self) => JsonConvert.SerializeObject(self, Raona1.Converter.Settings);
        public static string ToJson(this Budget self) => JsonConvert.SerializeObject(self, Raona1.Converter.Settings);
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
    }
}
