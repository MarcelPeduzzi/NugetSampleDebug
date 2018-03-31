using System;

namespace Peduzzi.Sample.NugetSampleDebug
{
    public class Calculate
    {
        public decimal Add (decimal value1, decimal value2)
        {
            decimal result = value1 + value2;

            return result;
        }

        public decimal Minus (decimal value1, decimal value2)
        {
            decimal result = value1 - value1;

            return result;
        }
    }
}
