﻿using System;
using Задание_3_2;
using Задание_3_2.Interfaces;

namespace Задание_3_2
{
    public sealed class TwoD_Array<T> : BaseArray<T>, ITwoD_Array
    {
        public T[,] _array;
        private ValueProvider<T> _provider;

        public TwoD_Array(int _Height, int _Length, ValueProvider<T> provider, bool Keyboard_Input)
        {
            _provider = provider;
            _array = new T[_Height, _Length];
            Create(Keyboard_Input);
        }
        public int Height
        {
            get
            {
                return _array.GetLength(0);
            }
        }

        public int Length
        {
            get
            {
                return _array.GetLength(1);
            }
        }

        protected override void Initialize()
        {
            Random rnd = new Random();
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    _array[i, j] = _provider.GetRandomValue();
                }
            }
        }

        protected override void Keyboard_Initialize()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    _array[i, j] = _provider.GetKeyboardInput();
                }
            }
        }

        //public override double Mid_Value()
        //{
        //    int value_sum = 0;
        //    for (int i = 0; i < Height; i++)
        //    {
        //        for (int j = 0; j < Length; j++)
        //        {
        //            value_sum += _array[i, j];
        //        }
        //    }
        //    return value_sum / _array.Length;
        //}

        public override void Print()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Console.Write(_array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //public void Print_Snake_Array()
        //{
        //    for (int i = 0; i < Height; i++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            for (int j = Length - 1; j >= 0; j--)
        //            {
        //                Console.Write(_array[i, j] + " ");
        //            }
        //        }
        //        else
        //        {
        //            for (int j = 0; j < Length; j++)
        //            {
        //                Console.Write(_array[i, j] + " ");
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}

