using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.TestTask.Classes
{
    //работая с этим классом можно добавлять различные фигуры
    //к примеру чтобы добавить квадрат или прямоугльник
    public class Shape
    {
        public int a, b, c;
        public int radius;
        public Shape(int radius)
        {
            this.radius = radius > 0 ? radius : 0;
        }
        public Shape(int a, int b,int c)
        {
            this.a = a > 0 ? a : 0;
            this.b = b > 0 ? b : 0;
            this.c = c > 0 ? c : 0;
        }

    }
}
