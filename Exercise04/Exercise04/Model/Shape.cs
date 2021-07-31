

using System;
using System.Xml.Serialization;

namespace Exercise04.Model
{
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Rectangle))]
    [Serializable]
    public class Shape
    {
        public virtual double Area { get; }
    }
}
