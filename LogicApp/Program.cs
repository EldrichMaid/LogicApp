using System.Net.Security;
using static System.Net.Mime.MediaTypeNames;

namespace LogicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string A = "";
            string B = "";
            bool C = A != B;
            Console.WriteLine(C);

            int Aa = 5;
            int Bb = 8;
            double X = 43.65;
            double Y = 28.74;
            bool Cc = (Aa < Bb) | (X > Y);
            Console.WriteLine(Cc);

            var Aaa = 6;
            var Bbb = 7;

            if (Aaa != Bbb)
            {
                Console.WriteLine("Условие истинно");
            }
            else
            {
                Console.WriteLine("Условие ложно");
            }

            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
            }

            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
            }
            
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var SwitchColor = Console.ReadLine(); 
            switch (SwitchColor)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is not in the options!");
                    break;
            }

            for (int i = 1;i<5; i++)
            {
                Console.WriteLine("Iteration {0}", i);
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }
            }

            Console.WriteLine("Цикл while");
            int k = 0;
            while (k < 3)
            {
                Console.WriteLine(k);

                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                switch (Console.ReadLine())
                {case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is yellow!");
                    break; 
                }
                k++;

            }
            Console.WriteLine("Цикл do while");
            int t = 0;
            do {
                Console.WriteLine(t);

                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }
                t++;
            } 
            while (t < 3);

            int kkk = 0;

            while (true)
            {
                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                Console.WriteLine(kkk);

                var text = Console.ReadLine();

                if (text == "stop")
                {
                    Console.WriteLine("Цикл остановлен");
                    break;
                }

                switch (text) 
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        continue;
                }
                kkk++;

            }

            string[] favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                Console.WriteLine("Введите любимый цвет номер {0}", i + 1);
                favcolors[i] = Console.ReadLine();
            }

            foreach (var MassColor in favcolors)
            {
                switch (MassColor)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        continue;
                }
            }

            Console.WriteLine("Введите своё имя");
            var name = Console.ReadLine();
            Console.WriteLine("Ваше имя по буквам: ");

            foreach (var ch in name)
            {
                Console.Write(ch + " ");
            }

            Console.WriteLine("Последняя буква вашего имени: {0}", name[name.Length - 1]);           
            Console.WriteLine("Введите своё имя ещё раз");
            var ReverseName = Console.ReadLine();
            Console.WriteLine("Ваше имя по буквам задом на перёд: ");

            for (int i = ReverseName.Length- 1; i<=0; i--)
            {
                Console.Write(ReverseName[i] + " ");
            }

            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
            Console.Write("Первый элемент: ");
            Console.WriteLine(array[0, 0]);

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.Write("Количество строк: ");
            Console.WriteLine(array.GetUpperBound(0) + 1 + " ");
            Console.Write("Количество колонок: ");
            Console.WriteLine(array.GetUpperBound(1) + 1 + " ");
            Console.Write("А теперь пройдёмся по строкам");

            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int n = 0; n < array.GetUpperBound(1) + 1; n++)
                    Console.Write(array[i, n] + " ");

                Console.WriteLine();
            }

            Console.Write("А теперь пройдёмся по столбцам с новым массивом");
            int[,] AnotherArray = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            for (int i = 0; i < AnotherArray.GetUpperBound(0) + 1; i++)
            {
                for (int n = 0; n < AnotherArray.GetUpperBound(1) + 1; n++)
                    Console.Write(AnotherArray[n, i] + " ");

                Console.WriteLine();
            }

            var TestArray = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int Local;

            for (int i = 0; i < TestArray.Length; i++)
            {
                for (int j = i + 1; j < TestArray.Length; j++)
                {
                    if (TestArray[i] > TestArray[j])
                    {
                        Local = TestArray[i];
                        TestArray[i] = TestArray[j];
                        TestArray[j] = Local;
                    }
                }
            }

            Console.Write("Упорядочиваем массив по возрастанию");
            foreach (var result in TestArray)
            {
                Console.Write(result);
            }

            int sum = 0;

            for (int i = 0; i < TestArray.Length; i++)
            {
                sum += TestArray[i];
            }

            Console.Write("Суммируем");
            Console.WriteLine(sum);

            Console.Write("Зубчатый массив");
            foreach (var hew in favcolors)
            {
                foreach (var item in hew)
                {
                    Console.Write(item + " ");
                }
            }

            Console.Write("Перебор зубчатого массива");
            int[][] SpikeArray = new int[3][];
            SpikeArray[0] = new int[2] { 1, 2 };
            SpikeArray[1] = new int[3] { 1, 2, 3 };
            SpikeArray[2] = new int[5] { 1, 2, 3, 4, 5 };
            foreach (var elem in SpikeArray)
            {
                foreach (var item in elem)
                {
                    Console.Write(item + " ");
                }
            }

            Console.Write("Поищем положительные числа");
            int[] SearchArray = {5,-6,43,-57,12,6,-8,0,32,-8,54,98,-65 };
            int Counter = 0;
            for (int i = 0; i < SearchArray.Length; i++)
            { 
                if (SearchArray[i] > 0) Counter++;
            }
            Console.WriteLine(Counter);

            Console.ReadKey();
        }
    }
}
