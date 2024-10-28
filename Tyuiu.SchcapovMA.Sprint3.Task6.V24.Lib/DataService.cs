﻿using System.Diagnostics.Metrics;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SchcapovMA.Sprint3.Task6.V24.Lib
{
    public class DataService : ISprint3Task6V24
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int counter = 0;
            for (int i = startValue; i <= stopValue; i++) 
            {
                for (int j = 1; j <= i; j++) 
                {
                    if (i % j == 0) 
                    {
                        counter++;
                    }
                }
            }
         return counter;
        }
    }
}
