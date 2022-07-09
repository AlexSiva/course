namespace WhilePractice
{
    public static class Task2
    {
        /// <summary>
        /// Calculate the following sum
        /// 1/(1*2) - 1/(2*3) + 1/(3*4) + ... + (-1)^(n+1) / (n * (n + 1)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double SumSequenceElements(int n)
        {
            double sum = 0, i = 1, k;

            while (i <= n && n > 0)
            {
                k = i * (i + 1);
                if (i % 2 == 0)
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
