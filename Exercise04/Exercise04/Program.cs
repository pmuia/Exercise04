using System;
using Exercise04.Model;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            var listofshapes = CreateShapeList();

            //Console.WriteLine(listofshapes);

            //Console.ReadLine();

            XmlSerializer ser = new XmlSerializer(typeof(List<Shape>));

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string fullpath = System.IO.Path.Combine(path, "shapes.txt");

            Stream stream = File.OpenWrite(fullpath);

            ser.Serialize(stream, listofshapes);

            XmlReader xmlReader = XmlReader.Create(stream);

            List<Shape> loadedShapesXml = ser.Deserialize(xmlReader) as List<Shape>;

            foreach(Shape item in loadedShapesXml)
            {
                Console.WriteLine("{0} is {1} and has an area of {2:N2}", item.GetType().Name, item.Area);
            }
        }

        private static object CreateShapeList()
        {
            var listOfShapes = new List<Shape>
            {
                new Circle { Colour = "Red", Radius = 2.5 },

                new Rectangle {Colour = "Blue", Height = 20.0, Width = 10.0},

                new Circle { Colour = "Green", Radius = 8.0 },

                new Circle { Colour = "Purple", Radius = 12.3 },

                new Rectangle {Colour = "Blue", Height = 45, Width = 18.0}
            };

            return listOfShapes;
        }
    }    
}
