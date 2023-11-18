using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MeshcheryakovPV.Sprint5.Task1.V1.Lib;

namespace Tyuiu.MeshcheryakovPV.Sprint5.Task1.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Мещеряков П. В. | ИИПБ 23-2";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                  *");
            Console.WriteLine("* Задания #1                                                               *");
            Console.WriteLine("* Вариант #1                                                               *");
            Console.WriteLine("* Выполнил: Мещеряков Павел Викторович | ИИПБ 23-2                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дана функция, произвести табулирование на заданном диапазоне [-5:5]      *");
            Console.WriteLine("* c шагом один. Произвести проверку деления на 0.Вернуть 0 при делении     *");
            Console.WriteLine("* в текстовый файл OutPutFileTask1.txt и вывести на консоль.Округлить до 2 *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine();
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");



            Console.ReadKey();
        }
    }
}
