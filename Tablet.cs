using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
    internal class Tablet : Device
    {
        private string m_materialCorpus;
        public string Material
        {
            get { return m_materialCorpus; }
            set { m_materialCorpus = value; }
        }
        private uint m_battery;
        public uint Battery
        {
            get { return m_battery; }
            set { m_battery = value; }
        }
        public Tablet(string material, int battery, string manuName, string model, string color, double price, int count) : base(manuName, model, color, price, count)
        {
            try
            {
                Material = material;
                Battery = (uint)battery;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error {0}", e.Message);
            }


            Console.WriteLine("В склад завезли планшет");
        }
        public override void PrintInfoDevice()
        {
            string nameDevice = "Планшет";
            int temp = Console.WindowWidth;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0," + temp / 2 + "}", nameDevice);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Материал корпуса - {Material}\nБатарея - {Battery}");
            base.PrintInfoDevice();
        }

        public override void RedactionInfo()
        {
            ConsoleKey user;
            do
            {
                Console.Clear();
                PrintInfoDevice();
                Console.WriteLine("1)Material\n2)Battery\n3)Base character\nEscape)Exit");
                user = Console.ReadKey(true).Key;
                Console.Write("Input Value: ");
                switch (user)
                {
                    case ConsoleKey.D1:
                        {
                            string temp = Convert.ToString(Console.ReadLine());
                            Material = temp;
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            uint temp = Convert.ToUInt32(Console.ReadLine());
                            Battery = temp;
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
