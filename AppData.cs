using System;
using System.Xml.Serialization;

namespace LoadUsersFromFile
{
    [Serializable]
    [XmlRoot("data")]
    public class AppData
    {
        [XmlArray(IsNullable = true)]
        public User[] Users { get; set; }
    }
}
