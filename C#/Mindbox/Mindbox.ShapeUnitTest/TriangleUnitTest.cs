using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mindbox.TestTask.Shapes;
using Mindbox.TestTask.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox.ShapeUnitTest
{
    [TestClass]
    public class TriangleUnitTest
    {
        [TestMethod]
        public void Triangle_CalcluateSquare_ShouldReturnCorrectResult()
        {
            Triangle triangle = new Triangle(2,3,4);
            var result = triangle.CalculateSquare();
            var excepted = 2.90;
            Assert.AreEqual(excepted, result);
        }
        [TestMethod]
        public void Triangle_IsRightTriangleTest_ShouldReturnTrue()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            var result = triangle.IsRightTriangle();
            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(TriangleSideZeroException),"Triangle side was 0 or negative")]
        public void Triangle_TriangleSideZeroException()
        {
            Triangle triangle = new Triangle(0, -1, 2);
            var result = triangle.CalculateSquare();
        }
    }
}
