using System;
using System.IO;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace LoadUsersFromFile
{
    public static class IOUtil
    {
        public static T ParseJsonFile<T>(string path)
        {
            using(var reader = new StreamReader(path))
            {
                var data = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(data);
            }
        }

        public static void WriteToXmlFile(object o, string path)
        {
            var serializer = new XmlSerializer(o.GetType());
            using (var writer = new StreamWriter(path, false))
            {
                serializer.Serialize(writer, o);
            }
        }
    }
}
