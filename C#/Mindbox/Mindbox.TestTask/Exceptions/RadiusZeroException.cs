using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.TestTask.Exceptions
{
    public class RadiusZeroException : Exception
    {
        public RadiusZeroException(string message) : base(message)
        {

        }
    }
}
