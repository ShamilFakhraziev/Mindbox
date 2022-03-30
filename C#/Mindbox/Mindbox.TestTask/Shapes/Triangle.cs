using Mindbox.TestTask.Classes;
using Mindbox.TestTask.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.TestTask.Shapes
{
    public class Triangle : Shape, IShapesCalculatable
    {
        public Triangle(int a, int b, int c) : base(a,b,c)
        {
        }

        /*насколько я знаю если сумма квадратов катетов (т.е. a и b)
        равна гипотенузе в квадрате то треуголник прямоугольный*/
        public bool IsRightTriangle()
        {
            return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2);
        }
        public double CalculateSquare()
        {
            if (a == 0 || b == 0 || c == 0) throw new TriangleSideZeroException("A,B or C was zero or negative");

            double halfPerimetr, square;

            //нахожу полупериметр необходимый для вычисления площади треугольника
            halfPerimetr = (a+b+c)*0.5;
            square = Math.Sqrt(halfPerimetr * (halfPerimetr-a) * (halfPerimetr-b) * (halfPerimetr-c));

            return Math.Round(square,2);
        }
    }
}
