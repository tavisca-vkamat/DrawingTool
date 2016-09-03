using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DrawLine;
using ObjectFactory;
using DrawingTool;
using DrawCircle;
using DrawRectangle;

namespace DrawingTool.Tests
{
    [TestClass]
    public class DrawingTests
    {
        [TestMethod]
        public void TestLineDraw()
        {
        //    ILine line = Factory.GetInstanceILine();
        //    line = UserInput.GetLineCoordinate("100,100","300,350");

        //    line.DrawLine();
        }

        //[TestMethod]
        //public void TestCircleDraw()
        //{
        //    ICircle circle = Factory.GetInstanceICircle();
        //    circle = UserInput.GetCircleProperties("100,100","50");

        //    circle.DrawCircle();
        //}

        //[TestMethod]
        //public void TestRectangleDraw()
        //{
        //    IRectangle rectangle = Factory.GetInstanceIRectangle();

        //    rectangle = UserInput.GetRectangleDiagonal("0,0","100,100");

        //    rectangle.DrawRectangle();
        //}
    }
}
