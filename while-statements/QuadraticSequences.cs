namespace WhileStatements
{
    public static class QuadraticSequences
    {
        public static long SumQuadraticSequenceTerms1(long a, long b, long c, long maxTerm)
        {
            int i = 1;
            long sum = 0, term = 0;

            while (term <= maxTerm)
            {
                term = (a * i * i) + (b * i) + c;
                if (term <= maxTerm)
                {
                    sum += term;
                }

                i++;
            }

            return sum;
        }

        public static long SumQuadraticSequenceTerms2(long a, long b, long c, long startN, long count)
        {
            int i = 1, numb = 0, schet = 0;
            long sum = 0, term;

            while (numb < count)
            {
                term = (a * i * i) + (b * i) + c;
                schet++;
                if (schet >= startN)
                {
                    sum += term;
                    count--;
                }

                i++;
            }

            return sum;
        }
    }
}
