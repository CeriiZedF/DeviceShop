using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devices;
using Shops;

namespace Programm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Device m = new MobileTelephone(true, true, "asdasd", "dsadasd", "Blue", 100, 20);
            m.PrintInfoDevice();
            Device n = new Notebook(4, 16, "asdasd", "sdasdqwe", "qxxcv", 1000, 50);
            n.PrintInfoDevice();
            Device t = new Tablet("Lead", 5000, "aqwe", "aasd", "dasdasd", 1000, 20);
            t.PrintInfoDevice();

            Shop shop = new Shop();
            shop.Menu();
        }
    }
}
