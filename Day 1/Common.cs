using System;

namespace Day_1
{
    class Common
    {
        protected int calculateFuel(int mass)
        {
            var fuelRequired = (int)Math.Floor((decimal)mass / 3) - 2;
            return (fuelRequired < 0)
                ? 0
                : fuelRequired;
        }
    }
}
