using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DrawLine;
using ObjectFactory;
using DrawingTool;

namespace DrawingTool.Tests
{
    [TestClass]
    public class DrawingTests
    {
        [TestMethod]
        public void TestLineDraw()
        {
            ILine line = Factory.GetInstanceILine();
            line = UserInput.GetLineCoordinate("100,100","300,350");

            line.DrawLine();
        }
    }
}
