namespace WhilePractice
{
    public static class Task3
    {
        /// <summary>
        /// Calculate the following sum
        /// 1/1^5 + 1/2^5 + 1/3^5 + ... + 1/n^5, where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double SumSequenceElements(int n)
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
    }
}
