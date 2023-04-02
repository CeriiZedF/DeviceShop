using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devices;

namespace Shops
{
    internal class Shop
    {
        private List<Device> lists = new List<Device>();
        public void Menu()
        {
            ConsoleKey userInput;
            do
            {
                Console.WriteLine("1)Добавить устройство в список\n2)Удаление устройства по критериям\n3)Печать списка\n4)Поиск устроства по заданому критерию\n5)Выход");
                userInput = Console.ReadKey(true).Key;
                switch (userInput)
                {
                    case ConsoleKey.D1:
                        {
                            Console.Clear();
                            Console.WriteLine("1)Планшет\n2)Ноутбук\n3)Телефон");
                            userInput = Console.ReadKey(true).Key;
                            if(userInput == ConsoleKey.D1)
                            {
                                Tablet t = new Tablet("", 0, "", "", "", 0, 0);
                                t.RedactionInfo();
                                lists.Add(t);
                            }
                            if (userInput == ConsoleKey.D2)
                            {
                                Notebook n = new Notebook(0, 0, "", "", "", 0, 0);
                                n.RedactionInfo();
                                lists.Add(n);
                            }
                            if (userInput == ConsoleKey.D3)
                            {
                                MobileTelephone m = new MobileTelephone(false, false, "", "", "", 0, 0);
                                m.RedactionInfo();
                                lists.Add(m);
                            }
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            Console.WriteLine("OK");
                            Console.WriteLine("1)Производитель\n2)Модель\n3)Цвет\n4)Цена\n5)Количество");
                            userInput= Console.ReadKey(true).Key;
                            if(userInput == ConsoleKey.D1)
                            {
                                Console.WriteLine("Input manu");
                                string temp = Convert.ToString(Console.ReadLine());
                                for(int j = 0; j < lists.Count; j++)
                                {
                                    Console.WriteLine($"{lists[j].ManufacturerName} - {temp}");
                                    if(lists[j].ManufacturerName == temp)
                                    {
                                        lists.RemoveAt(j);
                                        break;
                                    }
                                }
                            }
                            else if(userInput == ConsoleKey.D2)
                            {
                                Console.WriteLine("Input model");
                                string temp = Convert.ToString(Console.ReadLine());
                                for (int j = 0; j < lists.Count; j++)
                                {
                                    if (lists[j].Model == temp)
                                    {
                                        lists.RemoveAt(j);
                                        break;
                                    }
                                }
                            }
                            if (userInput == ConsoleKey.D3)
                            {
                                Console.WriteLine("Input color");
                                string temp = Convert.ToString(Console.ReadLine());
                                for (int j = 0; j < lists.Count; j++)
                                {
                                    if (lists[j].Color == temp)
                                    {
                                        lists.RemoveAt(j);
                                        break;
                                    }
                                }
                            }
                            if (userInput == ConsoleKey.D4)
                            {
                                Console.WriteLine("Input price");
                                double temp = Convert.ToDouble(Console.ReadLine());
                                for (int j = 0; j < lists.Count; j++)
                                {
                                    if (lists[j].Price == temp)
                                    {
                                        lists.RemoveAt(j);
                                        break;
                                    }
                                }
                            }
                            if (userInput == ConsoleKey.D5)
                            {
                                Console.WriteLine("Input count");
                                uint temp = Convert.ToUInt32(Console.ReadLine());
                                for (int j = 0; j < lists.Count; j++)
                                {
                                    if (lists[j].Count == temp)
                                    {
                                        lists.RemoveAt(j);
                                        break;
                                    }
                                }
                            }
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            if (lists.Count <= 0)
                            {
                                Console.WriteLine("Node List");
                                break;
                            }
                            for (int i = 0; i < lists.Count; i++)
                            {
                                lists[i].PrintInfoDevice();
                            }
                            break;
                        }
                    case ConsoleKey.D4:
                        {
                            for(int i = 0; i < lists.Count; i++)
                            {
                                Console.WriteLine("1)Производитель\n2)Модель\n3)Цвет\n4)Цена\n5)Количество");
                                userInput = Console.ReadKey(true).Key;
                                if (userInput == ConsoleKey.D1)
                                {
                                    Console.WriteLine("Input data");
                                    string temp = Convert.ToString(Console.ReadLine());
                                    for (int j = 0; j < lists.Count; j++)
                                    {
                                        if (lists[j].ManufacturerName == temp)
                                        {
                                            lists[j].PrintInfoDevice();
                                        }
                                    }
                                    break;
                                }
                                if (userInput == ConsoleKey.D2)
                                {
                                    Console.WriteLine("Input data");
                                    string temp = Convert.ToString(Console.ReadLine());
                                    for (int j = 0; j < lists.Count; j++)
                                    {
                                        if (lists[j].Model == temp)
                                        {
                                            lists[j].PrintInfoDevice();
                                        }
                                    }
                                    break;
                                }
                                if (userInput == ConsoleKey.D3)
                                {
                                    Console.WriteLine("Input data");
                                    string temp = Convert.ToString(Console.ReadLine());
                                    for (int j = 0; j < lists.Count; j++)
                                    {
                                        if (lists[j].Color == temp)
                                        {
                                            lists[j].PrintInfoDevice();
                                        }
                                    }
                                    break;
                                }
                                if (userInput == ConsoleKey.D4)
                                {
                                    Console.WriteLine("Input data");
                                    double temp = Convert.ToDouble(Console.ReadLine());
                                    for (int j = 0; j < lists.Count; j++)
                                    {
                                        if (lists[j].Price == temp)
                                        {
                                            lists[j].PrintInfoDevice();
                                        }
                                    }
                                    break;
                                }
                                if (userInput == ConsoleKey.D2)
                                {
                                    Console.WriteLine("Input data");
                                    uint temp = Convert.ToUInt32(Console.ReadLine());
                                    for (int j = 0; j < lists.Count; j++)
                                    {
                                        if (lists[j].Count == temp)
                                        {
                                            lists[j].PrintInfoDevice();
                                        }
                                    }
                                    break;
                                }
                            }
                            break;
                        }
                    case ConsoleKey.D5:
                        {
                            Console.WriteLine("");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Неверная кнопка");
                            break;
                        }
                }
            } while (userInput != ConsoleKey.D5);
        }
    }
}
