using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignmentPart2
{
    class Program
    {
        static void Main(string[] args)
        {



            #region 1

            for (int printerPrintsCondition = 0; printerPrintsCondition <= 1; 
                printerPrintsCondition++)
            {
                
                for (int redLightFlashing = 0; redLightFlashing <= 1;
                    redLightFlashing++)
                {
                    for (int printerIsRecognizedByComputer = 0;
                        printerIsRecognizedByComputer < 2;
                        printerIsRecognizedByComputer++)
                    {
                        if (printerPrintsCondition == 0 && redLightFlashing
                            == 0 && printerIsRecognizedByComputer == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("If the printer doesn't print" +
                                ", has a red light flashing, and is not " +
                                "recognized by the computer, try these " +
                                "actions: ");
                            Console.WriteLine();
                            //call action methods
                            Class1 praf = new Class1();
                            praf.CheckPowerCable();
                            praf.CheckPrinterComputerCable();
                            praf.CheckPrinterSoftwareIsInstalled();
                            Console.WriteLine();
                        }

                        if (printerPrintsCondition == 0 && redLightFlashing
                            == 0 && printerIsRecognizedByComputer == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("If the printer doesn't print" +
                                ", has a red light flashing, and is " +
                                "recognized by the computer, try these " +
                                "actions: ");
                            Console.WriteLine();
                            //call action methods
                            Class1 praf = new Class1();
                            praf.CheckPaperJam();
                            Console.WriteLine();
                        }

                        if (printerPrintsCondition == 0 && redLightFlashing
                            == 1 && printerIsRecognizedByComputer == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("If the printer doesn't print" +
                                ", doesn't have a red light flashing, and is " +
                                "not recognized by the computer, try these " +
                                "actions: ");
                            Console.WriteLine();
                            //call action methods
                            Class1 praf = new Class1();
                            praf.CheckInk();
                            praf.CheckPaperJam();
                            Console.WriteLine();
                        }

                        if (printerPrintsCondition == 1 && redLightFlashing
                            == 1 && printerIsRecognizedByComputer == 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("If the printer prints" +
                                ", doesn't have a red light flashing, " +
                                "and is " +
                                "recognized by the computer, try these " +
                                "actions: ");
                            Console.WriteLine();
                            //call action methods
                            Class1 praf = new Class1();
                            praf.CheckInk();
                            Console.WriteLine();
                        }

                        if (printerPrintsCondition == 1 && redLightFlashing
                            == 1 && printerIsRecognizedByComputer == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("If the printer does print" +
                                ", has a red light flashing, and is not" +
                                "recognized by the computer, try these " +
                                "actions: ");
                            Console.WriteLine();
                            //call action methods
                            Class1 praf = new Class1();
                            praf.CheckPrinterSoftwareIsInstalled();
                            Console.WriteLine();
                        }

                        if (printerPrintsCondition == 1 && redLightFlashing
                            == 0 && printerIsRecognizedByComputer == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("If the printer does print" +
                                ", doesn't have " +
                                "a red light flashing, and is not " +
                                "recognized by the computer, try these " +
                                "actions: ");
                            Console.WriteLine();
                            //call action methods
                            Class1 praf = new Class1();
                            praf.CheckPrinterSoftwareIsInstalled();
                            Console.WriteLine();
                        }

                        if (printerPrintsCondition == 0 && redLightFlashing
                            == 1 && printerIsRecognizedByComputer == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("If the printer doesn't print" +
                                ", has a red light flashing, and is not " +
                                "recognized by the computer, try these " +
                                "actions: ");
                            Console.WriteLine();
                            //call action methods
                            Class1 praf = new Class1();
                            praf.CheckPrinterComputerCable();
                            praf.CheckPrinterSoftwareIsInstalled();
                            praf.CheckInk();
                            Console.WriteLine();
                        }
                    }
                }
            }

            #endregion


            #region region 2

            for (int i=0; i <=7; i++)
            {
                switch (i)
                {
                    case 0:
                        //print out conditions
                        //call action methods for NO, No, NO
                        break;
                    case 1:
                        break;
                }
            }

            #endregion



        }
        

    }
}
