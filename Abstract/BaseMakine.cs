using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Kapanis.Abstract
{
    public abstract class BaseMakine
    {
        public BaseMakine()
        {
            ProductionDate = DateTime.Now;
        }
        public DateTime ProductionDate { get; set; }

        public string SerialNumber { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string OperatingSystem { get; set; }

        public virtual void Writeİnfo()
        {
            Console.WriteLine("Device Production Date is :" + ProductionDate);
            Console.WriteLine("Device Serial Number is :" + SerialNumber);
            Console.WriteLine("Device Name is :" +Name);
            Console.WriteLine("Device Description is : " + Description);
            Console.WriteLine("Device Operating System is : " + OperatingSystem);
        }
        public abstract void GetBrandName();
    }
    
   
}
