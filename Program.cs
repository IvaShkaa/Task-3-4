using System;
using System.Globalization;
using Задание_3_2.Interfaces;

namespace Задание_3_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("С каким типом данных будете работать? (<int> <double> <bool> <string>)");
            string ans = Console.ReadLine();
            if (ans == "string")
            {
                BaseArray<string>[] Base_Array = new BaseArray<string>[2];

                ValueProvider<string> provider = new StringProvider();

                //Cоздание одномерного массива
                Console.WriteLine("Введите длинну Вашего одномерного массива: ");
                int Arr_Len = int.Parse(Console.ReadLine());

                Console.WriteLine("Если вы хотите ввести значения с помощью клавиатуры введите true");
                Console.WriteLine("Если вы не хотите вводить значения с помощью клавиатуры введите false");
                bool _1DKeyboard_Input = bool.Parse(Console.ReadLine());  

                Base_Array[0] = new OneD_Array<string>(Arr_Len, provider, _1DKeyboard_Input);

                //Cоздание двумерного массива
                Console.WriteLine("Введите количество строк в вашем двумерном массиве:");
                int _2D_Arr_height = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите количество столбцов в вашем двумерном массиве:");
                int _2D_Arr_length = int.Parse(Console.ReadLine());

                Console.WriteLine("Если вы хотите ввести значения с помощью клавиатуры введите true");
                Console.WriteLine("Если вы не хотите вводить значения с помощью клавиатуры введите false");
                bool _2DKeyboard_Input = bool.Parse(Console.ReadLine());

                Base_Array[1] = new TwoD_Array<string>(_2D_Arr_length, _2D_Arr_height, provider, _2DKeyboard_Input);

                //Вывод всего массива
                for (int i = 0; i < Base_Array.Length; i++)
                {
                    Console.WriteLine("Вывод массива:");
                    Base_Array[i].Print();
                }
            }

            else if (ans == "int")
            {
                BaseArray<int>[] Base_Array = new BaseArray<int>[2];

                ValueProvider<int> provider = new IntValProvider();

                //Cоздание одномерного массива
                Console.WriteLine("Введите длинну Вашего одномерного массива: ");
                int Arr_Len = int.Parse(Console.ReadLine());

                Console.WriteLine("Если вы хотите ввести значения с помощью клавиатуры введите true");
                Console.WriteLine("Если вы не хотите вводить значения с помощью клавиатуры введите false");
                bool _1DKeyboard_Input = bool.Parse(Console.ReadLine());

                Base_Array[0] = new OneD_Array<int>(Arr_Len, provider, _1DKeyboard_Input);

                //Cоздание двумерного массива
                Console.WriteLine("Введите количество строк в вашем двумерном массиве:");
                int _2D_Arr_height = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите количество столбцов в вашем двумерном массиве:");
                int _2D_Arr_length = int.Parse(Console.ReadLine());

                Console.WriteLine("Если вы хотите ввести значения с помощью клавиатуры введите true");
                Console.WriteLine("Если вы не хотите вводить значения с помощью клавиатуры введите false");
                bool _2DKeyboard_Input = bool.Parse(Console.ReadLine());

                Base_Array[1] = new TwoD_Array<int>(_2D_Arr_length, _2D_Arr_height, provider, _2DKeyboard_Input);

                //Вывод всего массива
                for (int i = 0; i < Base_Array.Length; i++)
                {
                    Console.WriteLine("Вывод массива:");
                    Base_Array[i].Print();
                }
            }

            else if (ans == "bool")
            {
                BaseArray<bool>[] Base_Array = new BaseArray<bool>[2];

                ValueProvider<bool> provider = new BoolProvider();

                //Cоздание одномерного массива
                Console.WriteLine("Введите длинну Вашего одномерного массива: ");
                int Arr_Len = int.Parse(Console.ReadLine());

                Console.WriteLine("Если вы хотите ввести значения с помощью клавиатуры введите true");
                Console.WriteLine("Если вы не хотите вводить значения с помощью клавиатуры введите false");
                bool _1DKeyboard_Input = bool.Parse(Console.ReadLine());

                Base_Array[0] = new OneD_Array<bool>(Arr_Len, provider, _1DKeyboard_Input);

                //Cоздание двумерного массива
                Console.WriteLine("Введите количество строк в вашем двумерном массиве:");
                int _2D_Arr_height = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите количество столбцов в вашем двумерном массиве:");
                int _2D_Arr_length = int.Parse(Console.ReadLine());

                Console.WriteLine("Если вы хотите ввести значения с помощью клавиатуры введите true");
                Console.WriteLine("Если вы не хотите вводить значения с помощью клавиатуры введите false");
                bool _2DKeyboard_Input = bool.Parse(Console.ReadLine());

                Base_Array[1] = new TwoD_Array<bool>(_2D_Arr_length, _2D_Arr_height, provider, _2DKeyboard_Input);

                //Вывод всего массива
                for (int i = 0; i < Base_Array.Length; i++)
                {
                    Console.WriteLine("Вывод массива:");
                    Base_Array[i].Print();
                }
            }

            else if (ans == "double")
            {
                BaseArray<double>[] Base_Array = new BaseArray<double>[2];

                ValueProvider<double> provider = new DoubleProvider();

                //Cоздание одномерного массива
                Console.WriteLine("Введите длинну Вашего одномерного массива: ");
                int Arr_Len = int.Parse(Console.ReadLine());

                Console.WriteLine("Если вы хотите ввести значения с помощью клавиатуры введите true");
                Console.WriteLine("Если вы не хотите вводить значения с помощью клавиатуры введите false");
                bool _1DKeyboard_Input = bool.Parse(Console.ReadLine());

                Base_Array[0] = new OneD_Array<double>(Arr_Len, provider, _1DKeyboard_Input);

                //Cоздание двумерного массива
                Console.WriteLine("Введите количество строк в вашем двумерном массиве:");
                int _2D_Arr_height = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите количество столбцов в вашем двумерном массиве:");
                int _2D_Arr_length = int.Parse(Console.ReadLine());

                Console.WriteLine("Если вы хотите ввести значения с помощью клавиатуры введите true");
                Console.WriteLine("Если вы не хотите вводить значения с помощью клавиатуры введите false");
                bool _2DKeyboard_Input = bool.Parse(Console.ReadLine());

                Base_Array[1] = new TwoD_Array<double>(_2D_Arr_length, _2D_Arr_height, provider, _2DKeyboard_Input);

                //Вывод всего массива
                for (int i = 0; i < Base_Array.Length; i++)
                {
                    Console.WriteLine("Вывод массива:");
                    Base_Array[i].Print();
                }
            }

            else
            {
                Console.WriteLine("Введите тип данных!!!");
            }

            Console.ReadLine();
        }
    }
}
