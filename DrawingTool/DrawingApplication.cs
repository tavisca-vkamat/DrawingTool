﻿using System;
using DrawLine;
using ObjectFactory;
using DrawRectangle;
using DrawCircle;
using log4net;
using log4net.Config;

namespace DrawingTool
{
    class DrawingApplication
    {
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        [STAThread]
        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            logger.Debug("Programm starts ");
            int userChoice;

            /* Menu for user */
            Console.WriteLine("\n\n---------------MENU---------------\n1.Line\n2.Circle\n3.Rectangle\n4.Exit");
            userChoice = int.Parse(Console.ReadLine());
            switch (userChoice)
            {
                case 1:/* Line drawing */
                    try
                    {
                        ILine line = Factory.GetInstanceILine();
                        line = UserInput.GetLineCoordinate();

                        line.DrawLine();
                        logger.Info("line draw successful");
                    }
                    catch(Exception exception)
                    {
                        logger.Error("in line Draw exception: "+exception.ToString());
                        Console.WriteLine("in line Draw exception: " + exception.ToString());
                        Console.ReadLine();
                    }
                    break;

                case 2:/* Circle drawing */
                    try
                    {
                        ICircle circle = Factory.GetInstanceICircle();
                        circle = UserInput.GetCircleProperties();

                        circle.DrawCircle();

                        logger.Info("line draw successful");
                    }
                    catch (Exception exception)
                    {
                        logger.Error("in circle Draw exception: " + exception.ToString());
                    }
                    
                    break;

                case 3:/* Rectangle drawing */
                    try
                    {
                        IRectangle rectangle = Factory.GetInstanceIRectangle();
                        
                        rectangle = UserInput.GetRectangleDiagonal();

                        rectangle.DrawRectangle();

                        logger.Info("line draw successful");
                    }
                    catch (Exception exception)
                    {
                        logger.Error("in rectangle Draw exception: " + exception.ToString());
                    }
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

