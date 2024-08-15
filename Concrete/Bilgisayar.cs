using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4Kapanis.Abstract;

namespace Week4Kapanis.Concrete
{
    internal class Computer : BaseMakine
    {
        int _numberOfPort;

        public int UsbPortNumber
        {
            get
            {
                return _numberOfPort;
            }
            set
            {
                if (value == 2 || value == 4)
                {
                    _numberOfPort = value;
                }
                else
                {
                    Console.WriteLine("You cannot give the usb port value any value other than 2 or 4. Value is set to -1");
                    _numberOfPort = -1;
                }
            }
        }
        public bool HasBluetooth { get; set; }

        public override void Writeİnfo()
        {
            base.Writeİnfo();
            Console.WriteLine(UsbPortNumber);
            Console.WriteLine(HasBluetooth ? "Device has Bluetooth!" : "Device Has not bluetooth");
        }
        public override void GetBrandName()
        {
            Console.WriteLine("Computer name is : " + Name);
            Console.WriteLine("Computer Serial number is : " + SerialNumber);
            Console.WriteLine("Computer Production Date is : " + ProductionDate);
            Console.WriteLine("Computer Operating System is : " + OperatingSystem);
            Console.WriteLine("Computer Description is : " + Description);
            Console.WriteLine("Computer Usb Port number is : " + _numberOfPort);
        }

    }
}
