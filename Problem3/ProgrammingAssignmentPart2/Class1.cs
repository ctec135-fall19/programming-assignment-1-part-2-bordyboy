using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignmentPart2
{
    class Class1
    {
        #region action methods

        public void CheckPowerCable()
        {
            Console.WriteLine("Check if the power cable is working");
        }
        public void CheckPrinterComputerCable()
        {
            Console.WriteLine("Check if cable connecting from printer" +
                " to computer is working well");
        }
        public void CheckPrinterSoftwareIsInstalled()
        {
            Console.WriteLine("Check if the printer software is installed");
        }
        public void CheckInk()
        {
            Console.WriteLine("Check ink and replace if empty.");
        }

        public void CheckPaperJam()
        {
            Console.WriteLine("Check if paper is jammed");
        }

        #endregion
    }
}
