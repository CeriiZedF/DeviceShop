using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
    internal class MobileTelephone : Device
    {
        private bool m_withTelephoneCase;
        public bool Case
        {
            get { return m_withTelephoneCase; }
            set { m_withTelephoneCase = value; }
        }
        private bool m_withProtectiveGlass;
        public bool ProtectiveGlass
        {
            get { return m_withProtectiveGlass; }
            set { m_withProtectiveGlass = value; }
        }
        public MobileTelephone(bool withCase, bool protect, string manuName, string model, string color, double price, int count) : base(manuName, model, color, price, count)
        {

            Case = withCase;
            ProtectiveGlass = protect;
            Console.WriteLine("В склад завезли телефон");
        }
        public override void PrintInfoDevice()
        {
            string nameDevice = "Телефон";
            int temp = Console.WindowWidth;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0," + temp / 2 + "}", nameDevice);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Чехол - {InfoWith(m_withTelephoneCase)}\nЗащитное стекло - {InfoWith(m_withProtectiveGlass)}");
            base.PrintInfoDevice();
        }
        public string InfoWith(bool temp)
        {
            if(temp)
            {
                return "Присутствует";
            }
            return "Отсутствует";
        }

        public override void RedactionInfo()
        {
            ConsoleKey user;
            do
            {
                Console.Clear();
                PrintInfoDevice();
                Console.WriteLine("1)Case\n2)Protected Glass\n3)Base character\nEscape)Exit");
                user = Console.ReadKey(true).Key;
                Console.Write("Input Value: ");
                switch (user)
                {
                    case ConsoleKey.D1:
                        {
                            bool temp = Convert.ToBoolean(Console.ReadLine());
                            Case = temp;
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            bool temp = Convert.ToBoolean(Console.ReadLine());
                            ProtectiveGlass = temp;
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
