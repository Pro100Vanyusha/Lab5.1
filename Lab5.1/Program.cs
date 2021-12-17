using System;

namespace Lab5._1
{
    interface IFigure
    {
        string sizeFigure { get; }
        string Type();
        string Square();
        string Length();
    }
    interface IColoredFigure : IFigure
    {
        string name { get; }
    }
    class Rectangle : IFigure
    {
        public double a { get; set; }
        public double b { get; set; }

        public Rectangle(double A, double B)
        {
            this.a = A;
            this.b = B;
        }
        public string sizeFigure
        {
            get
            {
                return $"The size of the figure: A = {a}, B = {b}";
            }
        }
        public string Length()
        {
            double d = Math.Round(Math.Sqrt(Math.Pow(b, 2) + Math.Pow(a, 2)), 2);
            return $"The diagonal length of the figure = {d}";
        }
        public string Square()
        {
            double s = Math.Round(a * b, 2);
            return $"The area of the figure = {s}";
        }
        public string Type()
        {
            return "Shape type: Rectangle";
        }
    }
    class ColoredRectangle : Rectangle, IColoredFigure
    {
        public string color { get; set; }
        public string name { get; set; }

        public ColoredRectangle(double A, double B, string C) : base(A, B)
        {
            this.color = C;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle[] rectangle = {
            new Rectangle (2.75, 1.25),
            new Rectangle (6.25, 3),
            new Rectangle (7.5, 5.15)
        };

            foreach (Rectangle str in rectangle)
            {
                Console.WriteLine($"{str.Type()}\n{str.sizeFigure}\n{str.Square()}\n{str.Length() }");
            }
        }
    }
}