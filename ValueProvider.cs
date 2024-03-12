using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3_2
{
    public abstract class ValueProvider<T>
    {
        public abstract T GetRandomValue();

        public abstract T GetKeyboardInput();
    }

    sealed class IntValProvider : ValueProvider<int>
    {
        Random rnd = new Random();
        public override int GetRandomValue()
        {
            return rnd.Next(10, 300);
        }
        public override int GetKeyboardInput()
        {
            return int.Parse(Console.ReadLine());
        }
    }

    sealed class DoubleProvider : ValueProvider<double>
    {
        Random rnd = new Random();
        public override double GetRandomValue()
        {
            return rnd.NextDouble();
        }

        public override double GetKeyboardInput()
        {
            return double.Parse(Console.ReadLine());
        }
    }

    sealed class BoolProvider : ValueProvider<bool>
    {
        Random rnd = new Random();
        public override bool GetRandomValue()
        {
            if (rnd.Next(0, 2) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool GetKeyboardInput()
        {
            return bool.Parse(Console.ReadLine());
        }
    }

    sealed class StringProvider : ValueProvider<string>
    {
        Random rnd = new Random();
        string line = "fhdghd%90jfv()hb7383*@@hdgfdfh:;/.1268734t+-=абгдеёжзийклмнопрст";
        string random_line = "";
        public override string GetRandomValue()
        {
            for (int i = 0; i < rnd.Next(1, 9); i++)
            {
                random_line += line[rnd.Next(0, 64)];
            }
            return random_line;
        }

        public override string GetKeyboardInput()
        {
            return Console.ReadLine();
        }
    }
}
