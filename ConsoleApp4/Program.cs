﻿using System;
using System.Reflection.Metadata.Ecma335;

namespace laba1
{
    public class App
    {
        string _name = "Name";
        double _memory2 = 0;
        public string name
        {
            get => _name;
            set
            {
                try
                {
                    if (value == "")
                    {
                        throw new ArgumentException("Введите корректное имя приложения");
                    }
                    else
                    {
                        _name = value;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Environment.Exit(1);
                }
            }
        }
        public double memory2
        {
            get => _memory2;
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("Введите корректное значение занимаемой памяти");
                    }
                    else
                    {
                        _memory2 = value;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Environment.Exit(1);
                }
            }
        }
        public App(string name1, double memory1)
        {
            name = name1;
            memory2 = memory1;
        }
    }

    public class Smartphone
    {
        string manufacturer12 = "Name";
        string _model = "Name";
        public string manufacturer
        {
            set
            {
                try
                {
                    if (value == "")
                    {
                        throw new ArgumentException("Введите корректное название производителя");
                    }
                    else
                    {
                        manufacturer12 = value;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Environment.Exit(1);
                }
            }
            get => manufacturer12;
        }
        public string model
        {
            set
            {
                try
                {
                    if (value == "")
                    {
                        throw new ArgumentException("Введите корректное название модели");
                    }
                    else
                    {
                        _model = value;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Environment.Exit(1);
                }
            }
            get => _model;

        }
        double cpuf = 0;
        int cpuc = 0;
        public double CPUfreq
        {
            set
            {
                try
                {
                    if (value > 4000 || value < 0)
                    {
                        throw new ArgumentException("Введите корректное значение частоты процессора");
                    }
                    else
                    {
                        cpuf = value;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Environment.Exit(1);
                }
            }
            get => cpuf;
        }
        public int CPUcore
        {
            set
            {
                try
                {
                    if (value > 12 || value < 1)
                    {
                        throw new ArgumentException("Введите корректное значение ядра процессора");
                    }
                    else
                    {
                        cpuc = value;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Environment.Exit(1);
                }
            }
            get => cpuc;
        }
        int ram = 0;
        public int RAM
        {
            set
            {
                try
                {
                    if (value > 16 || value < 1)
                    {
                        throw new ArgumentException("Введите корректное значение RAM");
                    }
                    else
                    {
                        ram = value;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Environment.Exit(1);
                }
            }
            get => ram;
        }
        string tRam = "Name";
        double mem = 0;
        public string typeOfRAM
        {
            set
            {
                try
                {
                    if (value == "")
                    {
                        throw new ArgumentException("Введите корректное значение");
                    }
                    else
                    {
                        tRam = value;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Environment.Exit(1);
                }
            }
            get => tRam;
        }
        public double memory
        {
            set
            {
                try
                {
                    if (value > 1024 || value < 8)
                    {
                        throw new ArgumentException("Введите корректное значение памяти телефона");
                    }
                    else
                    {
                        mem = value;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Environment.Exit(1);
                }
            }
            get => mem;
        }
        string os = "Name";
        string im = "Name";
        public string OS
        {
            set
            {
                try
                {
                    if (value == "")
                    {
                        throw new ArgumentException("Введите корректное значение операционной системы");
                    }
                    else
                    {
                        os = value;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Environment.Exit(1);
                }
            }
            get => os;
        }
        public string IMEI
        {
            set
            {
                try
                {
                    if (value.Length != 16 && value.Length != 15)
                    {
                        throw new ArgumentException("Введите корректное значение IMEI");
                    }
                    else
                    {
                        im = value;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Environment.Exit(1);
                }
            }
            get => im;
        }

        public double memory_used = 0;
        public List<App> apps = new List<App>();
        public Smartphone(string manafacturer1, string model1, double cpufreq, int cpucore, int ram, string typeofram, int memory1, string os1, string imei1)
        {
            manufacturer = manafacturer1;
            model = model1;
            CPUfreq = cpufreq;
            CPUcore = cpucore;
            RAM = ram;
            typeOfRAM = typeofram;
            memory = memory1;
            OS = os1;
            IMEI = imei1;
        }

        public void HardReset()
        {
            apps.Clear();
        }

        public void print()
        {
            int i = 1;
            Console.WriteLine("Ваш смартфон: {0} {1}", manufacturer, model);
            Console.WriteLine("Операционная система: {0}", OS);
            Console.WriteLine("IMEI: {0}", IMEI, model);
            Console.WriteLine("Процессор. Частота: {0} МГц. Количество ядер: {1}", CPUfreq, CPUcore);
            Console.WriteLine("Оперативная память. Объем: {0} Гб. ТИп: {1}", RAM, typeOfRAM);
            if (apps.Count == 0)
            {
                Console.WriteLine("На устройстве не найдены установленные приложения.");
            }
            else
            {
                Console.WriteLine("Список установленных приложений: ");
                foreach (var app in apps)
                {
                    Console.Write($"{i}. ");
                    Console.WriteLine("Название:{0} , занимаемая память: {1} Гб", app.name, app.memory2);
                    i++;
                }

            }
            Console.WriteLine("===========================================================================");
        }
        public void InstallApp(string name, double memory2)
        {

            foreach (App app in apps)
            {

                memory_used += app.memory2;

                if (app.name == name)
                {
                    Console.WriteLine("Приложение с таким названием уже существует. Установка отменена.");
                    return;
                }

            }

            if (memory_used + memory2 > memory)
            {
                Console.WriteLine("На устройстве недостаточно места. Установка отменена.");

                return;
            }

            try
            {
                App app = new App(name, memory2);
                apps.Add(app);
            }

            catch (Exception)
            {
                throw (new Exception("Установка отменена."));
            }

        }
        public void DeleteApp(string name)
        {
            int index = -1;
            for (int i = 0; i < apps.Count; i++)
            {
                if (apps[i].name == name)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                apps.RemoveAt(index);
                Console.WriteLine("Приложение с названием " + name + " удалено.");
            }
            else
            {
                Console.WriteLine("Приложение с названием " + name + " не существует. Удаление не произошло.");
            }
        }

    }
    class Program
    {

        static void Main()
        {

            Smartphone s1 = new Smartphone("Apple", "SE", 1.7, 8, 6, "LPDDR3", 128, "IOS", "346741084731834");
            s1.print();

            s1.InstallApp("VK", 2);
            s1.InstallApp("VK", 15);
            s1.InstallApp("YouTube", 8);
            s1.InstallApp("YourNETI", 10);
            s1.InstallApp("Word", 9);
            s1.print();
            s1.DeleteApp("Word");
            s1.print();
            s1.HardReset();
            s1.print();

        }
    }
}