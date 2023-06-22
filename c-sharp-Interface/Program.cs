using c_sharp_Interface;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("enter the radius of the circle");
        double a=double.Parse(Console.ReadLine());

        Console.WriteLine("enter the hight of the rectangle");
        double b= double.Parse(Console.ReadLine());

        Console.WriteLine("enter the width of the rectangle");
        double c = double.Parse(Console.ReadLine());


        IShape[] shape = { new Circle(a), new Rectangle(b, c),new Square(2.5) };

        Console.WriteLine($"the Area of Circle is:{shape[0].getArea()}");
        Console.WriteLine($"the Area of Rectangle is:{shape[1].getArea()}");
        Console.WriteLine($"the Area of square  is:{shape[2].getArea()}");

        Square sqr1 =new Square(2.5);
        Square sqr2 = new Square(3);
        Console.WriteLine(sqr1.CompareTo(sqr2));
    }
}