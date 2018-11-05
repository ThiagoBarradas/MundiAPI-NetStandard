using Newtonsoft.Json.Converters;

namespace Mundipagg.NetStandard.Utilities
{
    public class CustomDateTimeConverter : IsoDateTimeConverter
    {
        public CustomDateTimeConverter(string format)
        {
            DateTimeFormat = format;
        }
    }
}