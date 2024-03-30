using System;

public interface IScalable
{
    void Scale(double s);
}

public class Circle : IScalable
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public void Scale(double s)
    {
        Radius *= s;
    }

    public override string ToString()
    {
        return $"Circle with radius {Radius}";
    }
}

public class Rectangle : IScalable
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public void Scale(double s)
    {
        Width *= s;
        Height *= s;
    }

    public override string ToString()
    {
        return $"Rectangle with width {Width} and height {Height}";
    }
}

class Program
{
    static void Main(double[] args)
    {
        while (true)
        {
            Console.WriteLine("Квадрат = 1");
            Console.WriteLine("Круг = 2");

            double a = Console.ReadLine();

            if (a == 1)
            {
                Console.WriteLine("Ширина");
                double Width = Console.ReadLine();

                Console.WriteLine("Висота");
                double Height = Console.ReadLine();

                Console.WriteLine("На скільки маштабуємо");
                double s = Console.ReadLine();





                Circle circle = new Circle(s);
                Rectangle rectangle = new Rectangle(Width, Height);

                Console.WriteLine("Original:");
                Console.WriteLine(circle);
                


            }
            else if (a == 2)
            {
                Console.WriteLine("Радіус кола");
                double Radius = Console.ReadLine();

                Console.WriteLine("На скільки маштабуємо");
                double s = Console.ReadLine();

                circle.Scale(s);
                rectangle.Scale(Radius);

                Console.WriteLine("\nAfter scaling:");
                
                Console.WriteLine(rectangle);
            }

            else { Console.WriteLine('Мдаааа перероблюй')}


        }
    }
}
