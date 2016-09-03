using System;
using DrawLine;
using ObjectFactory;
using DrawRectangle;
using DrawCircle;

namespace DrawingTool
{
    class DrawingApplication
    {
        [STAThread]
        static void Main(string[] args)
        {
            int userChoice;

            /* Menu for user */
            Console.WriteLine("\n\n---------------MENU---------------\n1.Line\n2.Circle\n3.Rectangle\n4.Exit");
            userChoice = int.Parse(Console.ReadLine());
            switch (userChoice)
            {
                case 1:/* Line drawing */
                    ILine line = Factory.GetInstanceILine();
                    //line = UserInput.GetLineCoordinate();

                    line.DrawLine();
                    break;

                case 2:/* Circle drawing */
                    ICircle circle = Factory.GetInstanceICircle();
                    circle = UserInput.GetCircleProperties();

                    circle.DrawCircle();
                    break;

                case 3:/* Rectangle drawing */
                    IRectangle rectangle = Factory.GetInstanceIRectangle();
                    rectangle = Factory.GetInstanceIRectangle();
                    rectangle = UserInput.GetRectangleDiagonal();

                    rectangle.DrawRectangle();
                    break;

                case 4:/* Exit */
                    Console.WriteLine("\nThank you come again!!!");
                    break;

                default:
                    Console.WriteLine("\nInvalid input");
                    break;
            }
        }
    }
}
