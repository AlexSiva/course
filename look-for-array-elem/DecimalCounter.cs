using System;

namespace LookingForArrayElements
{
    public static class DecimalCounter
    {
        /// <summary>
        /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetDecimalsCount(decimal[]? arrayToSearch, decimal[]?[]? ranges)
        {
            int numb = 0, i = 0, j = 0;
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (ranges is null)
            {
                throw new ArgumentNullException(nameof(ranges));
            }

            for (int k = 0; k < ranges.Length; k++)
            {
                if (ranges[k] is null)
                {
                    throw new ArgumentNullException(nameof(ranges));
                }
            }

            for (int k = 0; k < ranges.Length; k++)
            {
                if (ranges[k]!.Length > 2)
                {
                    throw new ArgumentException("oops");
                }
            }

            if (arrayToSearch.Length == 0)
            {
                return 0;
            }

            if (ranges.Length == 0)
            {
                return 0;
            }

            do
            {
                do
                {
                    if (arrayToSearch[j] >= ranges[i]![0] && arrayToSearch[j] <= ranges[i]![1])
                    {
                        numb++;
                    }

                    j++;
                }
                while (j < arrayToSearch.Length);

                j = 0;
                i++;
            }
            while (i < ranges.Length);

            return numb;
        }

        /// <summary>
        /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetDecimalsCount(decimal[]? arrayToSearch, decimal[]?[]? ranges, int startIndex, int count)
        {
            int numb = 0;
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (ranges is null)
            {
                throw new ArgumentNullException(nameof(ranges));
            }

            for (int k = 0; k < ranges.Length; k++)
            {
                if (ranges[k] is null)
                {
                    throw new ArgumentNullException(nameof(ranges));
                }
            }

            for (int k = 0; k < ranges.Length; k++)
            {
                if (ranges[k]!.Length > 2)
                {
                    throw new ArgumentException("oops");
                }
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (startIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            if (arrayToSearch.Length == 0)
            {
                return 0;
            }

            if (ranges.Length == 0)
            {
                return 0;
            }

            for (int i = 0; i < ranges!.Length; i++)
            {
                for (int j = startIndex; j < startIndex + count; j++)
                {
                    if (arrayToSearch[j] >= ranges[i]![0] && arrayToSearch[j] <= ranges[i]![1])
                    {
                        numb++;
                    }
                }
            }

            return numb;
        }
    }
}
