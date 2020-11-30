using System;
using System.IO;
using System.Xml.Serialization;

namespace PaytureTest
{
    public static class XmlHelper
    {
        public static object XmlDeserializeFromString(string objectData, Type type)
        {
            var serializer = new XmlSerializer(type);
            object result;

            using (TextReader reader = new StringReader(objectData))
            {
                result = serializer.Deserialize(reader);
            }

            return result;
        }
    }
}
