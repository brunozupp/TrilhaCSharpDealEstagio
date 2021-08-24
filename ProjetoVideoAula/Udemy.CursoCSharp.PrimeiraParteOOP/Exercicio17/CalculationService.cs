﻿using System;
using System.Collections.Generic;

namespace Udemy.CursoCSharp.PrimeiraParteOOP.Exercicio17
{
    public class CalculationService<E> where E : IComparable
    {
        public T Max<T>(List<T> list) where T : IComparable
        {
            T max = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }

            return max;
        }
    }
}
