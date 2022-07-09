namespace WhileStatements
{
    public static class GeometricSequences
    {
        public static uint SumGeometricSequenceTerms1(uint a, uint r, uint n)
        {
            uint i = 0, sum = 0, rpow, j;
            while (i < n)
            {
                j = 0;
                rpow = 1;
                while (j < i)
                {
                    rpow *= r;
                    j++;
                }

                sum += a * rpow;
                i++;
            }

            return sum;
        }

        public static uint SumGeometricSequenceTerms2(uint n)
        {
            uint i = 0, sum = 0, rpow, j;
            const int firstTerm = 13;
            const int commonDifference = 3;
            while (i < n)
            {
                j = 0;
                rpow = 1;
                while (j < i)
                {
                    rpow *= commonDifference;
                    j++;
                }

                sum += firstTerm * rpow;
                i++;
            }

            return sum;
        }

        public static uint CountGeometricSequenceTerms3(uint a, uint r, uint maxTerm)
        {
            uint i = 0, count = 0, rpow, j, term = 0;
            while (term <= maxTerm)
            {
                j = 0;
                rpow = 1;
                while (j < i)
                {
                    rpow *= r;
                    j++;
                }

                term = a * rpow;
                if (term <= maxTerm)
                {
                    count++;
                }

                i++;
            }

            return count;
        }

        public static uint CountGeometricSequenceTerms4(uint a, uint r, uint n, uint minTerm)
        {
            uint i = 0, count = 0, rpow, j, term = 0;
            while (i < n)
            {
                j = 0;
                rpow = 1;
                while (j < i)
                {
                    rpow *= r;
                    j++;
                }

                term = a * rpow;
                if (term >= minTerm)
                {
                    count++;
                }

                i++;
            }

            return count;
        }
    }
}
