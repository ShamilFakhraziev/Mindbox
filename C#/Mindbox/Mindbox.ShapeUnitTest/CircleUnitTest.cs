using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mindbox.TestTask.Exceptions;
using Mindbox.TestTask.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.ShapeUnitTest
{
    [TestClass]
    public class CircleUnitTest
    {
        [TestMethod]
        public void Circle_CalculateSquare_ShouldReturnCorrectResult()
        {
            Circle circle = new Circle(60);
            var result = circle.CalculateSquare();
            var excepted = 11309.73;
            Assert.AreEqual(excepted, result);

        }

        [TestMethod]
        [ExpectedException(typeof(RadiusZeroException),"Radius was null or negative")]
        public void Circle_CalculateSquare_RadiusIsZeroOrNegativeException()
        {
            Circle circle = new Circle(0);
            var result = circle.CalculateSquare();
        }
    }
}
