namespace WhilePractice
{
    public static class Task6
    {
        /// <summary>
        /// Calculate the following sum
        /// -1/3 + 1/5 - 1/7 + ... + (-1)^n / (2 * n + 1), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double SumSequenceElements(int n)
        {
            double sum = 0, i = 1, k;

            while (i <= n && n > 0)
            {
                k = 1 + (2 * i);
                if ((i % 2) != 0)
                {
                    k *= -1;
                }

                sum += 1 / k;
                i++;
            }

            return sum;
        }
    }
}
