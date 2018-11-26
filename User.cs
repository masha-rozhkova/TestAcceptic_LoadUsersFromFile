using System;
using System.Xml;
using System.Xml.Serialization;

namespace LoadUsersFromFile
{
    public enum Color
    {
        Brown,
        Blue,
        Green,
        Black
    }

    [Serializable]
    public class User
    {
        [XmlText]
        public string Name { get; set; }

        [XmlAttribute]
        public int Age { get; set; }

        [XmlAttribute]
        public double Weight { get; set; }

        [XmlAttribute]
        public Color EyeColor { get; set; }
        
    }
}
