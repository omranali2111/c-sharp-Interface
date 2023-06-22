using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Interface
{
    internal  interface IShape
    {
        public double getArea();
       // public void Square(double length);
    }

    class Rectangle: IShape
    {
        double hight;
        double Width;
        public Rectangle(double hight, double width)
        {
            this.hight = hight;
            this.Width = width;
        }
        public double getArea()
        {
            return hight* Width;
        }
    }
    class Circle: IShape
    {
       
        double Radius;
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public  double getArea()
        {
            return (Math.PI * Radius * Radius);
        }
    }

    class Square : IShape, IComparable<Square>
    {
        double length;

        public double getArea()
        {
            return length * 2;
        }
        public Square(double length)
        {
            this.length = length;
        }
        public int CompareTo(Square? other)
        {
            if (other == null) { return 1; }
            if (this.length > other.length) { return 1; }
            else if (this.length < other.length) { return -1; }
            else { return 0; }
            
                
            
        }
    }
}
