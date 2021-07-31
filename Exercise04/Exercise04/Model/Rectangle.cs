

using System;

namespace Exercise04.Model
{
    [Serializable]
    public class Rectangle : Shape
    {
        public string Colour { get; set; }

        public double Height { get; set; }

        public double Width { get; set; }

        public override double Area
        {
            get
            {
                return Height * Width;
            }
        }
    }
}
