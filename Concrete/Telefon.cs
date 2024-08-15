using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4Kapanis.Abstract;

namespace Week4Kapanis.Concrete
{
    internal class Phone : BaseMakine
    {
        public bool HasTrLicence { get; set; }

        public override void Writeİnfo()
        {
            base.Writeİnfo();
            Console.WriteLine(HasTrLicence ? "Your Device has TR Licence " : "Your device has not TR Licence");
        }
        public override void GetBrandName()
        {
            Console.WriteLine("Phone Name is : " + Name);
            Console.WriteLine("Phone Serial Number is : " + SerialNumber);
            Console.WriteLine("Phone Production Date is : " + ProductionDate);
            Console.WriteLine("Phone Operating system is : " + OperatingSystem);
            Console.WriteLine("Phone Description is : " + Description);
            Console.WriteLine("Phone has TR Licence or Not ?" + HasTrLicence);
        }
    }
}
