using DrawCircle;
using DrawLine;
using DrawPoint;
using DrawRectangle;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectFactory
{
    public class Factory
    {
        static public ILine GetInstanceILine()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType(typeof(ILine), typeof(LineOperations));
            ILine line = container.Resolve<ILine>();
            return line;
        }

        static public IRectangle GetInstanceIRectangle()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType(typeof(IRectangle), typeof(RectangleOperations));
            IRectangle rectangle = container.Resolve<IRectangle>();
            return rectangle;
        }

        static public ICircle GetInstanceICircle()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType(typeof(ICircle), typeof(CircleOperations));
            ICircle circle = container.Resolve<ICircle>();
            return circle;
        }

        static public IPoint GetInstanceIPoint()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType(typeof(IPoint), typeof(PointOperations));
            IPoint point = container.Resolve<IPoint>();
            return point;
        }
    }
}
