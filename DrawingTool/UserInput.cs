using DrawLine;
using System;
using System.Linq;
using Validator;
using DrawRectangle;
using ObjectFactory;
using DrawCircle;
using DrawPoint;

namespace DrawingTool
{
    public class UserInput
    {
        public static ILine GetLineCoordinate()
        {
            ILine line = Factory.GetInstanceILine();
            IPoint startPoint = Factory.GetInstanceIPoint();

            /* get input from user start point */
            Console.Write("Enter co-ordinates x1,y1: ");
            string coOrdinate = Console.ReadLine();
            string[] coOrdinateValues = coOrdinate.Split(',');
            if (coOrdinateValues.Count() == 0)
            {
                line = null;
                return line;
            }
            else
            {
                /* parsing check and setting null if parsing fails */
                int parseStorageX = 0, parseStorageY = 0;

                if (InputValidator.IsInt(coOrdinateValues[0], ref parseStorageX) & InputValidator.IsInt(coOrdinateValues[1], ref parseStorageY))
                {
                    startPoint.X = parseStorageX;
                    startPoint.Y = parseStorageY;
                    line.startPoint = startPoint;
                }
                else
                {
                    line = null;
                    return line;
                }

                /* get input from user end point */
                IPoint endPoint = Factory.GetInstanceIPoint();
                Console.Write("Enter co-ordinates x2,y2: ");
                coOrdinate = Console.ReadLine();
                coOrdinateValues = coOrdinate.Split(',');

                /* parsing check and setting null if parsing fails */
                parseStorageX = 0; parseStorageY = 0;

                if (InputValidator.IsInt(coOrdinateValues[0], ref parseStorageX) & InputValidator.IsInt(coOrdinateValues[1], ref parseStorageY))
                {
                    endPoint.X = parseStorageX;
                    endPoint.Y = parseStorageY;
                    line.endPoint = endPoint;
                }
                else
                {
                    line = null;
                    return line;
                }
                return line;
            }
        }

        public static ICircle GetCircleProperties()
        {
            ICircle circle = Factory.GetInstanceICircle();
            IPoint center = Factory.GetInstanceIPoint();

            /* get input from user start point */
            Console.Write("Enter center coordinate x1,y1: ");
            string coOrdinate = Console.ReadLine();
            string[] coOrdinateValues = coOrdinate.Split(',');
            if (coOrdinateValues.Count() == 0)
            {
                circle = null;
                return circle;
            }
            else if (coOrdinateValues.Count() == 2)
            {
                /* parsing check and setting null if parsing fails */
                int parseStorageX = 0, parseStorageY = 0;

                if (InputValidator.IsInt(coOrdinateValues[0], ref parseStorageX) & InputValidator.IsInt(coOrdinateValues[1], ref parseStorageY))
                {
                    center.X = parseStorageX;
                    center.Y = parseStorageY;
                    circle.center = center;
                }
                else
                {
                    circle = null;
                    return circle;
                }

                /* get input from user radius */
                Console.Write("Enter radius: ");
                coOrdinate = Console.ReadLine();


                /* parsing check and setting null if parsing fails */
                int parseStorage = 0;

                if (InputValidator.IsInt(coOrdinate, ref parseStorage))
                {
                    circle.radius = parseStorage;
                }
                else
                {
                    circle = null;
                    return circle;
                }
                return circle;
            }//else if
            else
            {
                circle = null;
                return circle;
            }
        }//GetCircleProperties

        public static IRectangle GetRectangleDiagonal()
        {
            IRectangle rectangle = Factory.GetInstanceIRectangle();
            IPoint diagonalStart = Factory.GetInstanceIPoint();
            IPoint diagonalEnd = Factory.GetInstanceIPoint();

            /* get input from user start point */
            Console.Write("Enter diagonal start co-ordinates x1,y1: ");
            string coOrdinate = Console.ReadLine();
            string[] coOrdinateValues = coOrdinate.Split(',');
            if (coOrdinateValues.Count() == 0)
            {
                rectangle = null;
                return rectangle;
            }
            else if (coOrdinateValues.Count() == 2)
            {
                /* parsing check and setting null if parsing fails */
                int parseStorageX = 0, parseStorageY = 0;

                if (InputValidator.IsInt(coOrdinateValues[0], ref parseStorageX) & InputValidator.IsInt(coOrdinateValues[1], ref parseStorageY))
                {
                    diagonalStart.X = parseStorageX;
                    diagonalStart.Y = parseStorageY;
                    rectangle.diagonalStartPoint = diagonalStart;
                }
                else
                {
                    rectangle = null;
                    return rectangle;
                }

                /* get input from user end point */

                Console.Write("Enter diagonal end co-ordinates x2,y2: ");
                coOrdinate = Console.ReadLine();
                coOrdinateValues = coOrdinate.Split(',');

                /* parsing check and setting null if parsing fails */
                parseStorageX = 0; parseStorageY = 0;

                if (InputValidator.IsInt(coOrdinateValues[0], ref parseStorageX) & InputValidator.IsInt(coOrdinateValues[1], ref parseStorageY))
                {
                    diagonalEnd.X = parseStorageX;
                    diagonalEnd.Y = parseStorageY;
                    rectangle.diagonalEndPoint = diagonalEnd;
                }
                else
                {
                    rectangle = null;
                    return rectangle;
                }
                return rectangle;
            }//else if
            else
            {
                rectangle = null;
                return rectangle;
            }
        }//GetRectangle
    }//class
}//namespace
