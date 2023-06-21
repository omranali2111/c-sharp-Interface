using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Interface
{
    internal interface IShape
    {
        public double getArea();
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
}
