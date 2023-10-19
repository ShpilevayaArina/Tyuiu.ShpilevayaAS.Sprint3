using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShpilevayaAS.Sprint3.Task0.V8.Lib
{
    public class DataService : ISprint3Task0V8
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multiplySeries = 1;

            int i;
            for ( i = startValue; i <= stopValue; i++)
            {
                multiplySeries = multiplySeries * ((Math.Pow(value, i) + 1) * (Math.Cos(4)));
            }
            return Math.Round(multiplySeries, 3);
        }
    }
}
