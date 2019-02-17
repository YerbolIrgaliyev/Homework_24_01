using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_24_01
{
    class Program
    {
        static void Main(string[] args)
        {
            File[] files = new File[5];
            files[0] = new File("file1", 253);
            files[1] = new File("file2", 456);
            files[2] = new File("file3", 785);
            files[3] = new File("file4", 156);
            files[4] = new File("file5", 322);

            Storage disk = new DVD { NameOfDevice = "DVD HOTISUBA", ModelOfDevice = "v. 5.5.02", ReadingSpeed = 1.32, type = RecordType.unilateral };
            Storage flash = new Flash { NameOfDevice = "Transcend", ModelOfDevice = "v. 2.0", Memory = 4, USBThreeSpeed = 480 };
            Storage hdd = new HDD { NameOfDevice = "TOSHIBA", ModelOfDevice = "v. 3.0", AmountOfSections = 5, MemoryOfSections = 9, USBTwoSpeed = 900 };

            Console.WriteLine(disk.GetAllInfo()); 
            Console.WriteLine(disk.Copying(files)); Console.WriteLine('\n');
            Console.WriteLine(flash.GetAllInfo()); 
            Console.WriteLine(flash.Copying(files)); Console.WriteLine('\n');
            Console.WriteLine(hdd.GetAllInfo()); 
            Console.WriteLine(hdd.Copying(files)); Console.WriteLine('\n');

            Console.ReadKey();
        }
    }
}
