using Week4Kapanis.Concrete;

class Program
{
    public static void Main(string[] args)
    {
        bool anotherDataInput = true;

        while (anotherDataInput)
        {
        choise: Console.WriteLine("Enter 1 to generate a Computer or Enter 2 to generate a Phone");
            int choise = Convert.ToInt32(Console.ReadLine());

            if (choise == 1)
            {
                Computer computer = new Computer();

                Console.WriteLine("Enter Computer Name :");
                computer.Name = Console.ReadLine();

                Console.WriteLine("Enter Computer Serial Number : ");
                computer.SerialNumber = Console.ReadLine();

                Console.WriteLine("Enter Computer Description");
                computer.Description = Console.ReadLine();

                Console.WriteLine("Enter Computer Operating System ");
                computer.OperatingSystem = Console.ReadLine();

                Console.WriteLine("Enter Number of usb ports : ");
                computer.UsbPortNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Computer has a Bluetooth ? ");
                computer.HasBluetooth = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Computer object is created with this propertys : ");
                computer.Writeİnfo();
            }
            else if (choise == 2)
            {
                Phone phone = new Phone();

                Console.WriteLine("Enter Phone Name : ");
                phone.Name = Console.ReadLine();

                Console.WriteLine("Enter Phone Serial Number : ");
                phone.SerialNumber = Console.ReadLine();

                Console.WriteLine("Enter Phone Description : ");
                phone.Description = Console.ReadLine();

                Console.WriteLine("Enter Phone Operating System : ");
                phone.OperatingSystem = Console.ReadLine();

                Console.WriteLine("The Phone Has a TR Licence ?");
                phone.HasTrLicence = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Phone object is created with this propertys : ");
                phone.Writeİnfo();

            }
            else
            {
                Console.WriteLine("You entered an incorrect value!");
                goto choise;
            }

            Console.WriteLine("Do you want to add another product ? (Y/N) ");
        choise2: string choise2 = Console.ReadLine();

            if (choise2 == "Y")
            {

            }

            else if (choise2 == "N")
            {
                Console.WriteLine("Have a Good Day!");
                anotherDataInput = false;
            }
            else
            {
                Console.WriteLine("You entered an incorrect value!");
                goto choise2;
            }
        }
    }
}