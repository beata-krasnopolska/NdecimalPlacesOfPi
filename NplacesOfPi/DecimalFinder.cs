using System;

namespace NplacesOfPi
{
    class DecimalFinder
    {
        const double _pi_value = Math.PI;
        public double Find(int n)
        {
            var deci = Math.Round(_pi_value, n);
            return deci;
        }
    }
}
