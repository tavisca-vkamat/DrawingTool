using DrawLine;
using System;
using System.Linq;
using Validator;
using DrawRectangle;
using ObjectFactory;
using DrawCircle;
using DrawPoint;
using DrawTriangle;
using DrawHexagon;

namespace DrawingTool
{
    public class UserInput
    {
        public static ILine GetLineCoordinate()
        {
            ILine line = Factory.GetInstanceILine();
            Point startPoint = new Point();

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
                Point endPoint = new Point();
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
            Point center = new Point();

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

        internal static IHexagon GetHexagonePropertis()
        {
            IHexagon hexagone = Factory.GetInstanceIHexagone();
            Point center = new Point();

            /* get input from user center*/
            Console.Write("Enter co-ordinates center (x,y): ");
            string coOrdinate = Console.ReadLine();
            string[] coOrdinateValues = coOrdinate.Split(',');
            /* parsing check and setting null if parsing fails */
            int parseStorageX = 0, parseStorageY = 0;
            if (coOrdinateValues.Count() == 2 && InputValidator.IsInt(coOrdinateValues[0], ref parseStorageX) & InputValidator.IsInt(coOrdinateValues[1], ref parseStorageY))
            {
                center.X = parseStorageX;
                center.Y = parseStorageY;
                hexagone.center = center;
            }
            else
            {
                hexagone = null;
                return hexagone;
            }

            /* user input for side length */
            Console.Write("Enter side length of hexagone: ");
            int storage;
            if (int.TryParse(Console.ReadLine(), out storage))
                hexagone.side = storage;
            else
            {
                hexagone = null;
                return hexagone;
            }
            return hexagone;
        }

        internal static ITriangle GetTrianglePoints()
        {
            ITriangle triangle = Factory.GetInstanceITriangle();
            Point one = new Point();
            Point two = new Point();
            Point three = new Point();

            /* get input from user point ---------------------1*/
            Console.Write("Enter co-ordinates point one (x1,y1): ");
            string coOrdinate = Console.ReadLine();
            string[] coOrdinateValues = coOrdinate.Split(',');
            /* parsing check and setting null if parsing fails */
            int parseStorageX = 0, parseStorageY = 0;
            if (coOrdinateValues.Count() == 2 && InputValidator.IsInt(coOrdinateValues[0], ref parseStorageX) & InputValidator.IsInt(coOrdinateValues[1], ref parseStorageY))
            {
                one.X = parseStorageX;
                one.Y = parseStorageY;
                triangle.one = one;
            }
            else
            {
                triangle = null;
                return triangle;
            }

            /* get input from user point two-----------------2*/
            Console.Write("Enter co-ordinates point two (x2,y2): ");
            coOrdinate = Console.ReadLine();
            coOrdinateValues = coOrdinate.Split(',');
            /* parsing check and setting null if parsing fails */
            parseStorageX = 0; parseStorageY = 0;
            if (coOrdinateValues.Count() == 2 && InputValidator.IsInt(coOrdinateValues[0], ref parseStorageX) & InputValidator.IsInt(coOrdinateValues[1], ref parseStorageY))
            {
                two.X = parseStorageX;
                two.Y = parseStorageY;
                triangle.two = two;
            }
            else
            {
                triangle = null;
                return triangle;
            }

            /* get input from user point three----------------3*/
            Console.Write("Enter co-ordinates point two (x3,y3): ");
            coOrdinate = Console.ReadLine();
            coOrdinateValues = coOrdinate.Split(',');
            /* parsing check and setting null if parsing fails */
            parseStorageX = 0; parseStorageY = 0;
            if (coOrdinateValues.Count() == 2 && InputValidator.IsInt(coOrdinateValues[0], ref parseStorageX) & InputValidator.IsInt(coOrdinateValues[1], ref parseStorageY))
            {
                three.X = parseStorageX;
                three.Y = parseStorageY;
                triangle.three = three;
            }
            else
            {
                triangle = null;
                return triangle;
            }

            return triangle;
        }

        public static IRectangle GetRectangleDiagonal()
        {
            IRectangle rectangle = Factory.GetInstanceIRectangle();
            Point diagonalStart = new Point();
            Point diagonalEnd = new Point();

            /* get input from user start point */
            Console.Write("Enter diagonal start co-ordinates x1,y1: ");
            string coOrdinate = Console.ReadLine();
            string[] coOrdinateValues = coOrdinate.Split(',');

            /* parsing check and setting null if parsing fails */
            int parseStorageX = 0, parseStorageY = 0;

            if (coOrdinateValues.Count() == 2 && InputValidator.IsInt(coOrdinateValues[0], ref parseStorageX) & InputValidator.IsInt(coOrdinateValues[1], ref parseStorageY))
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

            if (coOrdinateValues.Count() == 2 && InputValidator.IsInt(coOrdinateValues[0], ref parseStorageX) & InputValidator.IsInt(coOrdinateValues[1], ref parseStorageY))
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
        }//GetRectangle
    }//class
}//namespace
