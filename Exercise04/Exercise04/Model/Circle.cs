using System;

namespace Exercise04.Model
{
    [Serializable]
    public class Circle : Shape
    {
        public string Colour { get; set; }

        public double Radius { get; set; }

        public override double Area
        {
            get
            {
                return Radius * Radius * Math.PI;
            }
        }
    }
}
