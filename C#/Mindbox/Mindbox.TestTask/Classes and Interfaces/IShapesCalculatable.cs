using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.TestTask.Classes
{
    //в этом интерфейсе можно регисрировать сигнатуры методов 
    //для вычисления различных значений фигур
    public interface IShapesCalculatable
    {
        double CalculateSquare();
    }
}
