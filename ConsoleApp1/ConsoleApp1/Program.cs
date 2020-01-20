using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] array = new Shape[4]
            {
                new Circle(11),
                new Ellipse(5, 6),
                new Square(7),
                new Rombus(9)
            };

            for (int i = 0; i < array.Length; i++)
            {
                Print(array[i]);
            }

            Console.ReadKey();
        }

        static void Print(Shape s)
        {
            double area = 0;
            if (s is Circle)
            {
                area = ((Circle)s).Area;
            }

            if (s is Ellipse)
            {
                area = (s as Ellipse).Area;
            }

            if (s is Square)
            {
                area = (s as Square).Area;
            }

            if (s is Rombus)
            {
                area = (s as Rombus).Area;
            }

            Console.WriteLine(s.GetNameOfShape() + "\t\tArea equal is: " + area);
        }
    }

    public abstract class Shape
    {
        public abstract string GetNameOfShape();
    }

    public class Triangele : Shape
    {
        public override string GetNameOfShape()
        {
            return "Tringle";
        }
    }

    public class Circle : Shape
    {
        public Circle() { }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override string GetNameOfShape()
        {
            return "Circle";
        }

        public double Radius { get; set; }

        public virtual double Area
        {
            get
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }

    }

    public class Ellipse : Circle
    {
        public Ellipse() { }

        public Ellipse(double radius1, double radius2)
        {
            Radius1 = radius1;
            Radius2 = radius2;
        }

        public override string GetNameOfShape()
        {
            return "Ellipse";
        }

        public double Radius1 { get; set; }

        public double Radius2 { get; set; }

        new double Radius { get; set; }

        public override double Area
        {
            get
            {
                return Math.PI * Radius1 * Radius2;
            }
        }

    }

    public class Square : Shape
    {
        public Square() { }

        public Square(double side) { Side = side; }

        public override string GetNameOfShape()
        {
            return "Square";
        }

        public double Side { get; set; }

        public virtual double Area { get { return Side * Side; } }


    }

    public class Rombus : Square
    {
        public Rombus() { }

        public Rombus(double side) : base(side) { }

        public override string GetNameOfShape()
        {
            return "Rombus";
        }

        public override double Area => base.Area;

    }

}