using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Индивидуальное_задание
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Лабораторная работа №1, Структура консольного приложения");
            Console.WriteLine("Беляев Данил Геннадьевич");
            Console.WriteLine("ИНС-б-о-19-2, 09.03.02");
            Console.WriteLine("18.02.2001");
            Console.WriteLine("Ставрополь");
            Console.WriteLine("Физ-ра");
            Console.WriteLine("Краткое описание хоби, люблю спорт, т.д.");

            Console.WriteLine("Вариант №27");

            

            
           
            float y = 2;
            Console.WriteLine("\n y=2");

            float d = 15;
            Console.WriteLine("\n d=15");

            float Zze;
            Zze = 35/(d*d)+(y*d*d)-(d*d+y)/(4*y) ;

            Console.WriteLine("Значение переменной y равно {0}", y);
            Console.WriteLine("Значение переменной b равно {0}", d);
            Console.WriteLine("Значение переменно Zze равно 35/(d*d)+(y*d*d)-(d*d+y)/(4*y)= {0}", Zze);

            Console.ReadKey();


        }
    }
}
