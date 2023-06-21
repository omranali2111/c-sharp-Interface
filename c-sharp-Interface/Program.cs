using c_sharp_Interface;

internal class Program
{
    private static void Main(string[] args)
    {
     

        IShape[] shape =  { new Circle(2.3), new Rectangle(2.3, 3.5) };

        Console.WriteLine($"the Area of Circle is:{shape[0].getArea()}");
        Console.WriteLine($"the Area of Rectangle is:{shape[1].getArea()}");
    }
}