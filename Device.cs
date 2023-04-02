using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
    internal abstract class Device
    {
        private protected string m_manufacturerName;
        public string ManufacturerName
        {
            get { return m_manufacturerName; }
            set 
            {
                if(value.Length < 15)
                {
                    m_manufacturerName = value;
                }
            }
        }
        private protected string m_model;
        public string Model
        {
            get { return m_model; }
            set
            {
                if(value.Length < 10)
                {
                    m_model = value;
                }
            }
        }
        private protected string m_color;
        public string Color
        {
            get { return m_color; }
            set
            {
                if(value.Length < 10)
                {
                    m_color = value;
                }
            }
        }
        private protected double m_price;
        public double Price
        {
            get { return m_price; }
            set
            {
                if (0 > value || value <= double.MaxValue)
                {
                    m_price = value;
                }
            }
        }
        private protected uint m_count;
        public uint Count
        {
            get { return m_count; }
            set
            {
                if (0 >= value || value <= uint.MaxValue)
                {
                    m_count = value;
                }
            }
        }

        public Device(string manuName, string model, string color, double price, int count)
        {
            try
            {
                ManufacturerName = manuName;
                Model = model;
                Color = color;
                Price = price;
                Count = (uint)count;
            }
            catch(Exception e)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.BackgroundColor = ConsoleColor.White;
            }
        }
        virtual public void PrintInfoDevice()
        {
            Console.WriteLine($"Производитель - {ManufacturerName}\nМодель - {Model}\nЦвет - {Color}\nЦена - {Price}\nКоличество - {Count}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        virtual public void RedactionInfo()
        {
            ConsoleKey user;
            do
            {
                Console.Clear();
                PrintInfoDevice();
                Console.WriteLine("1)Производитель\n2)Модель\n3)Цвет\n4)Цена\n5)Количество");
                user = Console.ReadKey(true).Key;
                Console.Write("Input Value: ");
                switch (user)
                {
                    case ConsoleKey.D1:
                        {
                            string temp = Convert.ToString(Console.ReadLine());
                            ManufacturerName = temp;
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            string temp = Convert.ToString(Console.ReadLine());
                            Model = temp;
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            string temp = Convert.ToString(Console.ReadLine());
                            Color = temp;
                            break;
                        }
                    case ConsoleKey.D4:
                        {
                            double temp = Convert.ToDouble(Console.ReadLine());
                            Price = temp;
                            break;
                        }
                    case ConsoleKey.D5:
                        {
                            uint temp = Convert.ToUInt32(Console.ReadLine());
                            Count = temp;
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
