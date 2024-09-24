using System;
using System.Text;

namespace Essential1
{
    class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double s1, double s2)
        {
            side1 = s1;
            side2 = s2;
        }

        public double AreaCalculator()
        {
            return side1 * side2;
        }

        public double PerimetrCalculator()
        {
            return 2 * (side1 + side2);
        }

        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }

        public double Perimeter
        {
            get
            {
                return PerimetrCalculator();
            }
        }
    }

class Program

    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("Write the length of the first side:");
            double s1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Write the length of the second side:");
            double s2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(s1, s2);

            Console.WriteLine("The area of the rectangle:" + rectangle.Area);
            Console.WriteLine("Perimetr of the rectangle:" + rectangle.Perimeter);
        }
    }
}
