﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Mời bạn nhập ngày/tháng/năm của hôm nay.....");
            Nhap:
            Console.WriteLine("Ngày");
            bool daySuccess = int.TryParse(Console.ReadLine(), out int day);
            Console.WriteLine("Tháng");
            bool monthSuccess = int.TryParse(Console.ReadLine(), out int month);
            Console.WriteLine("Năm");
            bool yearSuccess = int.TryParse(Console.ReadLine(), out int year);
            if (daySuccess && monthSuccess && yearSuccess)
            {
                if(day <= 31 && month <= 12)
                {
                    goto Ketqua;
                }
                else
                {
                    Console.WriteLine("Mời bạn nhập lại.....");
                    goto Nhap;
                }
            }
            else
            {
                Console.WriteLine("Mời bạn nhập lại.....");
                goto Nhap;
            }
            Ketqua:
            DateTime date = new DateTime(year, month, day);
            int x = (int)date.DayOfWeek;
            switch(x)
            {
                case 0:
                    Console.WriteLine("Hôm nay là chủ nhật");
                    break;
                case 1:
                    Console.WriteLine("Hôm nay là thứ 2");
                    break;
                case 2:
                    Console.WriteLine("Hôm nay là thứ 3");
                    break;
                case 3:
                    Console.WriteLine("Hôm nay là thứ 4");
                    break;
                case 4:
                    Console.WriteLine("Hôm nay là thứ 5");
                    break;
                case 5:
                    Console.WriteLine("Hôm nay là thứ 6");
                    break;
                case 6:
                    Console.WriteLine("Hôm nay là thứ 7");
                    break;
            }
            Console.ReadKey();
        }
    }
}
