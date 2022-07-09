using System;

namespace ShiftArrayElements
{
    public static class Shifter
    {
        /// <summary>
        /// Shifts elements in a <see cref="source"/> array using <see cref="iterations"/> array for getting directions and iterations (see README.md for detailed instructions).
        /// </summary>
        /// <param name="source">A source array.</param>
        /// <param name="iterations">An array with iterations.</param>
        /// <returns>An array with shifted elements.</returns>
        /// <exception cref="ArgumentNullException">source array is null.</exception>
        /// <exception cref="ArgumentNullException">iterations array is null.</exception>
        public static int[] Shift(int[]? source, int[]? iterations)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (iterations == null)
            {
                throw new ArgumentNullException(nameof(iterations));
            }

            for (int j = 0; j < iterations!.Length; j++)
            {
                int numb = iterations[j];
                bool isEven = false;
                if (j % 2 == 0)
                {
                    isEven = true;
                }

                switch (isEven)
                {
                    case true:
                        {
                            for (int k = 0; k < numb; k++)
                            {
                                int temp = source![0];
                                for (int i = 0; i < source.Length - 1; i++)
                                {
                                    source[i] = source[i + 1];
                                }

                                source[source.Length - 1] = temp;
                            }

                            break;
                        }

                    case false:
                        {
                            for (int k = 0; k < numb; k++)
                            {
                                int temp = source![source.Length - 1];
                                for (int i = source.Length - 1; i > 0; i--)
                                {
                                    source[i] = source[i - 1];
                                }

                                source[0] = temp;
                            }

                            break;
                        }

                    default:
                        throw new InvalidOperationException("Incorrect value.");
                }
            }

            return source;
        }
    }
}
