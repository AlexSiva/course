using System;

namespace Gcd
{
    /// <summary>
    /// Provide methods with integers.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b)
        {
            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException($"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            }

            if (b < 0 && a < 0)
            {
                a *= -1;
                b *= -1;
            }
            else if (b < 0)
            {
                b *= -1;
            }
            else if (a < 0)
            {
                a *= -1;
            }

            while (a != b && a > 0 && b > 0)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            int k = a > b ? a : b;
            return k;
        }

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b, int c)
        {
            int gcd;
            if (a == int.MinValue || b == int.MinValue || c == int.MinValue)
            {
                throw new ArgumentOutOfRangeException($"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("Three numbers cannot be 0 at the same time.");
            }

            if (a == 0 && b == 0)
            {
                gcd = GetGcdByEuclidean(a, c);
                return GetGcdByEuclidean(gcd, b);
            }

            int k = GetGcdByEuclidean(a, b);
            return GetGcdByEuclidean(k, c);
        }

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b, params int[] other)
        {
            int i = 0, gcd1, k = 1, gcd2;
            bool p = false, r = true;
            while (i < other.Length)
            {
                if (other[i] == int.MinValue)
                {
                    p = true;
                    break;
                }

                i++;
            }

            i = 0;
            while (i < other.Length)
            {
                if (other[i] != 0)
                {
                    r = false;
                    k = other[i];
                    break;
                }

                i++;
            }

            if (a == int.MinValue || b == int.MinValue || p)
            {
                throw new ArgumentOutOfRangeException($"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0 && r)
            {
                throw new ArgumentException("Numbers cannot be 0 at the same time.");
            }

            if (a == 0 && b == 0)
            {
                gcd1 = GetGcdByEuclidean(k, a);
                gcd2 = GetGcdByEuclidean(gcd1, b);
            }
            else
            {
                gcd2 = GetGcdByEuclidean(a, b);
            }

            i = 0;
            while (i < other.Length)
            {
               gcd1 = GetGcdByEuclidean(other[i], gcd2);
               gcd2 = gcd1;
               i++;
            }

            return gcd2;
        }

        /// <summary>
        /// Calculates GCD of two integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int a, int b)
        {
            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException($"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            }

            if (b < 0)
            {
                b *= -1;
            }

            if (a < 0)
            {
                a *= -1;
            }

            if (a == 0)
            {
                return b;
            }

            if (b == 0)
            {
                return a;
            }

            if (a % 2 == 0 && b % 2 == 0)
            {
                return 2 * GetGcdByStein(a / 2, b / 2);
            }

            if (a % 2 == 0 && b % 2 != 0)
            {
                return GetGcdByStein(a / 2, b);
            }

            if (a % 2 != 0 && b % 2 == 0)
            {
                return GetGcdByStein(a, b / 2);
            }

            if (a < b)
            {
                return GetGcdByStein((b - a) / 2, a);
            }
            else
            {
                return GetGcdByStein((a - b) / 2, b);
            }
        }

        /// <summary>
        /// Calculates GCD of three integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int a, int b, int c)
        {
            int gcd;
            if (a == int.MinValue || b == int.MinValue || c == int.MinValue)
            {
                throw new ArgumentOutOfRangeException($"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("Three numbers cannot be 0 at the same time.");
            }

            if (a == 0 && b == 0)
            {
                gcd = GetGcdByStein(a, c);
                return GetGcdByStein(gcd, b);
            }

            int k = GetGcdByStein(a, b);
            return GetGcdByStein(k, c);
        }

        /// <summary>
        /// Calculates the GCD of integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int a, int b, params int[] other)
        {
            int i = 0, gcd1, k = 1, gcd2;
            bool p = false, r = true;
            while (i < other.Length)
            {
                if (other[i] == int.MinValue)
                {
                    p = true;
                    break;
                }

                i++;
            }

            i = 0;
            while (i < other.Length)
            {
                if (other[i] != 0)
                {
                    r = false;
                    k = other[i];
                    break;
                }

                i++;
            }

            if (a == int.MinValue || b == int.MinValue || p)
            {
                throw new ArgumentOutOfRangeException($"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0 && r)
            {
                throw new ArgumentException("Numbers cannot be 0 at the same time.");
            }

            if (a == 0 && b == 0)
            {
                gcd1 = GetGcdByStein(k, a);
                gcd2 = GetGcdByStein(gcd1, b);
            }
            else
            {
                gcd2 = GetGcdByStein(a, b);
            }

            i = 0;
            while (i < other.Length)
            {
                gcd1 = GetGcdByStein(other[i], gcd2);
                gcd2 = gcd1;
                i++;
            }

            return gcd2;
        }

        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b)
        {
            long start = System.Diagnostics.Stopwatch.GetTimestamp();
            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException($"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            }

            if (b < 0 && a < 0)
            {
                a *= -1;
                b *= -1;
            }
            else if (b < 0)
            {
                b *= -1;
            }
            else if (a < 0)
            {
                a *= -1;
            }

            while (a != b && a > 0 && b > 0)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }

            int k = a > b ? a : b;
            long end = System.Diagnostics.Stopwatch.GetTimestamp();
            elapsedTicks = end - start;
            return k;
        }

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b, int c)
        {
            long start = System.Diagnostics.Stopwatch.GetTimestamp(), end;
            int gcd;
            if (a == int.MinValue || b == int.MinValue || c == int.MinValue)
            {
                throw new ArgumentOutOfRangeException($"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("Three numbers cannot be 0 at the same time.");
            }

            if (a == 0 && b == 0)
            {
                gcd = GetGcdByEuclidean(a, c);
                end = System.Diagnostics.Stopwatch.GetTimestamp();
                elapsedTicks = end - start;
                return GetGcdByEuclidean(gcd, b);
            }

            int k = GetGcdByEuclidean(a, b);
            end = System.Diagnostics.Stopwatch.GetTimestamp();
            elapsedTicks = end - start;
            return GetGcdByEuclidean(k, c);
        }

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in Ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b, params int[] other)
        {
            int i = 0, gcd1, k = 1, gcd2;
            long start = System.Diagnostics.Stopwatch.GetTimestamp(), end;
            bool p = false, r = true;
            while (i < other.Length)
            {
                if (other[i] == int.MinValue)
                {
                    p = true;
                    break;
                }

                i++;
            }

            i = 0;
            while (i < other.Length)
            {
                if (other[i] != 0)
                {
                    r = false;
                    k = other[i];
                    break;
                }

                i++;
            }

            if (a == int.MinValue || b == int.MinValue || p)
            {
                throw new ArgumentOutOfRangeException($"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0 && r)
            {
                throw new ArgumentException("Numbers cannot be 0 at the same time.");
            }

            if (a == 0 && b == 0)
            {
                gcd1 = GetGcdByEuclidean(k, a);
                gcd2 = GetGcdByEuclidean(gcd1, b);
            }
            else
            {
                gcd2 = GetGcdByEuclidean(a, b);
            }

            i = 0;
            while (i < other.Length)
            {
                gcd1 = GetGcdByEuclidean(other[i], gcd2);
                gcd2 = gcd1;
                i++;
            }

            end = System.Diagnostics.Stopwatch.GetTimestamp();
            elapsedTicks = end - start;
            return gcd2;
        }

        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Stein algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long elapsedTicks, int a, int b)
        {
            long start = System.Diagnostics.Stopwatch.GetTimestamp(), end;
            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException($"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0)
            {
                throw new ArgumentException("Two numbers cannot be 0 at the same time.");
            }

            if (b < 0)
            {
                b *= -1;
            }

            if (a < 0)
            {
                a *= -1;
            }

            if (a == 0)
            {
                end = System.Diagnostics.Stopwatch.GetTimestamp();
                elapsedTicks = end - start;
                return b;
            }

            if (b == 0)
            {
                end = System.Diagnostics.Stopwatch.GetTimestamp();
                elapsedTicks = end - start;
                return a;
            }

            if (a % 2 == 0 && b % 2 == 0)
            {
                end = System.Diagnostics.Stopwatch.GetTimestamp();
                elapsedTicks = end - start;
                return 2 * GetGcdByStein(a / 2, b / 2);
            }

            if (a % 2 == 0 && b % 2 != 0)
            {
                end = System.Diagnostics.Stopwatch.GetTimestamp();
                elapsedTicks = end - start;
                return GetGcdByStein(a / 2, b);
            }

            if (a % 2 != 0 && b % 2 == 0)
            {
                end = System.Diagnostics.Stopwatch.GetTimestamp();
                elapsedTicks = end - start;
                return GetGcdByStein(a, b / 2);
            }

            if (a < b)
            {
                end = System.Diagnostics.Stopwatch.GetTimestamp();
                elapsedTicks = end - start;
                return GetGcdByStein((b - a) / 2, a);
            }
            else
            {
                end = System.Diagnostics.Stopwatch.GetTimestamp();
                elapsedTicks = end - start;
                return GetGcdByStein((a - b) / 2, b);
            }
        }

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Stein algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long elapsedTicks, int a, int b, int c)
        {
            int gcd;
            long start = System.Diagnostics.Stopwatch.GetTimestamp(), end;
            if (a == int.MinValue || b == int.MinValue || c == int.MinValue)
            {
                throw new ArgumentOutOfRangeException($"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("Three numbers cannot be 0 at the same time.");
            }

            if (a == 0 && b == 0)
            {
                gcd = GetGcdByStein(a, c);
                end = System.Diagnostics.Stopwatch.GetTimestamp();
                elapsedTicks = end - start;
                return GetGcdByStein(gcd, b);
            }

            int k = GetGcdByStein(a, b);
            end = System.Diagnostics.Stopwatch.GetTimestamp();
            elapsedTicks = end - start;
            return GetGcdByStein(k, c);
        }

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Stein algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in Ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long elapsedTicks, int a, int b, params int[] other)
        {
            int i = 0, gcd1, k = 1, gcd2;
            long start = System.Diagnostics.Stopwatch.GetTimestamp(), end;
            bool p = false, r = true;
            while (i < other.Length)
            {
                if (other[i] == int.MinValue)
                {
                    p = true;
                    break;
                }

                i++;
            }

            i = 0;
            while (i < other.Length)
            {
                if (other[i] != 0)
                {
                    r = false;
                    k = other[i];
                    break;
                }

                i++;
            }

            if (a == int.MinValue || b == int.MinValue || p)
            {
                throw new ArgumentOutOfRangeException($"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0 && r)
            {
                throw new ArgumentException("Numbers cannot be 0 at the same time.");
            }

            if (a == 0 && b == 0)
            {
                gcd1 = GetGcdByStein(k, a);
                gcd2 = GetGcdByStein(gcd1, b);
            }
            else
            {
                gcd2 = GetGcdByStein(a, b);
            }

            i = 0;
            while (i < other.Length)
            {
                gcd1 = GetGcdByStein(other[i], gcd2);
                gcd2 = gcd1;
                i++;
            }

            end = System.Diagnostics.Stopwatch.GetTimestamp();
            elapsedTicks = end - start;
            return gcd2;
        }
    }
}
