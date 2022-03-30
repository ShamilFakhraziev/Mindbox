using Mindbox.TestTask.Classes;
using Mindbox.TestTask.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.TestTask.Shapes
{
    public class Circle : Shape, IShapesCalculatable
    {
        public Circle(int radius) : base(radius)
        {

        }

        public double CalculateSquare()
        {
           if (radius == 0) throw new RadiusZeroException("Radius was zero or negative");
           return Math.Round(Math.PI * Math.Pow(radius,2),2);
        }
    }
}
