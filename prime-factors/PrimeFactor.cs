using System;

namespace PrimeFactors
{
    public static class PrimeFactor
    {
        /// <summary>
        /// Compute the prime factors of a given natural number.
        /// A prime number is only evenly divisible by itself and 1.
        /// Note that 1 is not a prime number.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>Prime factors of a given natural number.</returns>
        /// <exception cref="ArgumentException">Thrown when number less or equal 0.</exception>
        /// <example>
        /// 60 => {2, 2, 3, 5}
        /// 8 => {2, 2, 2}
        /// 12 => {2, 2, 3}
        /// 901255 => {5, 17, 23, 461}
        /// 93819012551 => {11, 9539, 894119}.
        /// </example>
        public static int[] GetFactors(int number)
        {
            int i = 2;
            bool k = true;

            if (number <= 0)
            {
                throw new ArgumentException($"{number} cannot be less or equals zero.");
            }

            List<int> array = new List<int>();
            while (number != 1)
            {
                if (number % i == 0)
                {
                    number /= i;
                    array.Add(i);
                }
                else
                {
                    k = false;
                    while (!k)
                    {
                        i++;
                        k = IsPrime(i);
                    }
                }
            }

            return array.ToArray();
        }

        public static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
