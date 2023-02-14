using System.Collections.Generic;
using System.IO;

using YamlDotNet.Serialization;

namespace eCI.helper
{
    internal class YamlParser
    {
        private static readonly IDeserializer deserializer = new DeserializerBuilder()
            .WithAttemptingUnquotedStringTypeDeserialization()
            .Build();

        Dictionary<string, string> parse(TextReader textReader)
        {
            return (Dictionary<string, string>)deserializer.Deserialize(textReader);
        }
    }
}
