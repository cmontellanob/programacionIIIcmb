using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class SigletonPatternDemo
    {
        static void Main(string[] args)
        {
            SingleObject uno = SingleObject.getInstance();
            uno.seta("buenos dias");
            uno.showMessage();
            SingleObject dos = SingleObject.getInstance();
            dos.seta("buenas tardes");
            uno.showMessage();
            Console.ReadKey();
        }
    }
}
