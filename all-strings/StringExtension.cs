using System;

namespace ShuffleCharacters
{
    public static class StringExtension
    {
        /// <summary>
        /// Shuffles characters in source string according some rule.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <param name="count">The count of iterations.</param>
        /// <returns>Result string.</returns>
        /// <exception cref="ArgumentNullException">Source string is null.</exception>
        /// <exception cref="ArgumentException">Source string is empty or a white space.</exception>
        /// <exception cref="ArgumentException">Count of iterations is less than 0.</exception>
        public static string ShuffleChars(string? source, int count)
        {
            string odd = string.Empty, even = string.Empty, k;
            int z = 0;
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source.Replace(" ", string.Empty, StringComparison.Ordinal) == odd)
            {
                throw new ArgumentException("smth");
            }

            if (source.Replace("  \t\n  \t \r", string.Empty, StringComparison.Ordinal) == odd)
            {
                throw new ArgumentException("smth");
            }

            if (source.Length == 0)
            {
                throw new ArgumentException("mda");
            }

            if (count < 0)
            {
                throw new ArgumentException("smth");
            }

            string str = source;
            for (int i = count; i > 0; i--)
            {
                for (int j = 0; j < source.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        k = even;
                        even = string.Concat(k, source[j].ToString());
                    }
                    else
                    {
                        k = odd;
                        odd = string.Concat(k, source[j].ToString());
                    }
                }

                source = string.Concat(even, odd);
                even = string.Empty;
                odd = string.Empty;
                z++;
                if (source == str)
                {
                    i = count % z;
                    i++;
                }
            }

            return source;
        }
    }
}
