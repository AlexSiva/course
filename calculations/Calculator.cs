using System;

namespace Calculations
{
    public static class Calculator
    {
        /// <summary>
        /// Calculate the following sum 1/1 + 1/2 + 1/3 + ... + 1/n, where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumOne(int n)
        {
            double i = 1, sum = 0;
            while (i <= n && n > 0)
            {
                sum += 1 / i;
                i++;
            }

            return sum;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1/(1*2) - 1/(2*3) + 1/(3*4) + ... + (-1)^(n+1) / (n * (n + 1)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumTwo(int n)
        {
            double sum = 0, i = 1, k, b = 1;

            while (i <= n && n > 0)
            {
                k = i * (i + 1);
                b *= k;
                sum += 1 / b;
                b /= k;
                b *= -1;
                i++;
            }

            return sum;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1/1^5 + 1/2^5 + 1/3^5 + ... + 1/n^5, where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumThree(int n)
        {
            double sum = 0, i = 1, k, j;

            while (i <= n && n > 0)
            {
                k = i;
                j = 0;
                while (j < 4)
                {
                    k *= i;
                    j++;
                }

                sum += 1 / k;
                i++;
            }

            return sum;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1/(3 * 3) + 1/(5 * 5) + 1/(7 * 7) + ... + 1/((2 * n + 1) * (2 * n + 1)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumFour(int n)
        {
            double sum = 0, i = 1, k;

            while (i <= n && n > 0)
            {
                k = ((2 * i) + 1) * ((2 * i) + 1);
                sum += 1 / k;
                i++;
            }

            return sum;
        }

        /// <summary>
        /// Calculate the following product
        /// (1 + 1/(1 * 1)) * (1 + 1/(2 * 2)) * (1 + 1/(3 * 3)) * ... * (1 + 1/(n * n)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Product of elements.</returns>
        public static double GetProductOne(int n)
        {
            double seq = 1, i = 1, k;

            while (i <= n && n > 0)
            {
                k = (1 / (i * i)) + 1;
                seq *= k;
                i++;
            }

            return seq;
        }

        /// <summary>
        /// Calculate the following sum
        /// -1/3 + 1/5 - 1/7 + ... + (-1)^n / (2 * n + 1), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumFive(int n)
        {
            double seq = 0, i = 1, k, b = -1;

            while (i <= n && n > 0)
            {
                k = 1 / ((2 * i) + 1);
                b *= k;
                seq += b;
                b /= k;
                b *= -1;
                i++;
            }

            return seq;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1!/1 + 2!/(1+1/2) + 3!/(1+1/2+1/3) + ... + 1*2*...* n/ (1+1/2+1/3+...+1/n), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumSix(int n)
        {
            double sum = 0, i = 0, k = 1, b = 0;

            while (i < n && n > 0)
            {
                k *= i + 1;
                b += 1 / (i + 1);
                sum += k / b;
                i++;
            }

            return sum;
        }

        /// <summary>
        /// Calculate the following sum
        /// Sqrt(2 + Sqrt(2 + ... + Sqrt(2))), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumSeven(int n)
        {
            double i = 1, k, b = 0;

            while (i <= n && n > 0)
            {
                k = Math.Sqrt(2 + b);
                b = k;
                i++;
            }

            return b;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1/sin(1) + 1/(sin(1)+sin(2)) + ...+  1/(sin(1)+sin(2)+...+sin(n)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumEight(int n)
        {
            double sum = 0, i = 1, k, b = 0;

            while (i <= n && n > 0)
            {
                k = (Math.PI * i) / 180;
                b += Math.Sin(k);
                sum += 1 / b;
                i++;
            }

            return sum;
        }
    }
}
