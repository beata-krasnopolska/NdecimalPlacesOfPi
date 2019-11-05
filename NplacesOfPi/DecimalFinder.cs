using System;

namespace NplacesOfPi
{
    class DecimalFinder
    {
        public double Find(int n)
        {
            var piDecimalPlaces = Math.Round(Math.PI, n);
            return piDecimalPlaces;
        }
    }
}
