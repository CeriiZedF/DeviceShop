using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
    internal class Notebook : Device
    {
        private uint m_countCoresProcessor;
        public uint Core
        {
            get { return m_countCoresProcessor; }
            set { m_countCoresProcessor = value; }
        }
        private uint m_ram;
        public uint Ram
        {
            get { return m_ram; }
            set { m_ram = value; }
        }
        public Notebook(int core, int ram, string manuName, string model, string color, double price, int count) : base(manuName, model, color, price, count)
        {
            try
            {
                Core = (uint)core;
                Ram = (uint)ram;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error {0}", e.Message);
            }
            

            Console.WriteLine("В склад завезли ноутбук");
        }
        public override void PrintInfoDevice()
        {
            string nameDevice = "Ноутбук";
            int temp = Console.WindowWidth;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0," + temp / 2 + "}", nameDevice);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Количество ядер процессора - {Core}\nОЗУ - {Ram}");
            base.PrintInfoDevice();
        }
        public override void RedactionInfo()
        {
            ConsoleKey user;
            do
            {
                Console.Clear();
                PrintInfoDevice();
                Console.WriteLine("1)Core\n2)Ram\n3)Base character\nEscape)Exit");
                user = Console.ReadKey(true).Key;
                Console.Write("Input Value: ");
                switch (user)
                {
                    case ConsoleKey.D1:
                        {
                            uint temp = Convert.ToUInt32(Console.ReadLine());
                            Core = temp;
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            uint temp = Convert.ToUInt32(Console.ReadLine());
                            Ram = temp;
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            base.RedactionInfo();
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            Console.WriteLine("Exit");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Error");
                            break;
                        }
                }
            } while (user != ConsoleKey.Escape);
        }

    }
}
