using System;

namespace LookingForArrayElements
{
    public static class FloatCounter
    {
        /// <summary>
        /// Searches an array of floats for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="rangeStart">One-dimensional, zero-based <see cref="Array"/> of the range starts.</param>
        /// <param name="rangeEnd">One-dimensional, zero-based <see cref="Array"/> of the range ends.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetFloatsCount(float[]? arrayToSearch, float[]? rangeStart, float[]? rangeEnd)
        {
            int count = 0;

            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (rangeStart is null)
            {
                throw new ArgumentNullException(nameof(rangeStart));
            }

            if (rangeEnd is null)
            {
                throw new ArgumentNullException(nameof(rangeEnd));
            }

            if (rangeEnd.Length != rangeStart.Length)
            {
                throw new ArgumentException("Method throws ArgumentException in case an arrays of range starts and range ends contain different number of elements.");
            }

            for (int i = 0; i < rangeStart.Length; i++)
            {
                if (rangeEnd[i] < rangeStart[i])
                {
                    throw new ArgumentException("Method throws ArgumentException in case the range start value is greater than the range end value.");
                }
            }

            if (arrayToSearch.Length == 0)
            {
                return 0;
            }

            for (int i = 0; i < rangeEnd.Length; i++)
            {
                for (int j = 0; j < arrayToSearch.Length; j++)
                {
                    if (arrayToSearch[j] >= rangeStart[i] && arrayToSearch[j] <= rangeEnd[i])
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        /// <summary>
        /// Searches an array of floats for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="rangeStart">One-dimensional, zero-based <see cref="Array"/> of the range starts.</param>
        /// <param name="rangeEnd">One-dimensional, zero-based <see cref="Array"/> of the range ends.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetFloatsCount(float[]? arrayToSearch, float[]? rangeStart, float[]? rangeEnd, int startIndex, int count)
        {
            int numb = 0, i = startIndex, j = 0;

            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (rangeStart is null)
            {
                throw new ArgumentNullException(nameof(rangeStart));
            }

            if (rangeEnd is null)
            {
                throw new ArgumentNullException(nameof(rangeEnd));
            }

            if (rangeEnd.Length != rangeStart.Length)
            {
                throw new ArgumentException("Method throws ArgumentException in case an arrays of range starts and range ends contain different number of elements.");
            }

            for (int k = 0; k < rangeStart.Length; k++)
            {
                if (rangeEnd[k] < rangeStart[k])
                {
                    throw new ArgumentException("Method throws ArgumentException in case the range start value is greater than the range end value.");
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

            if (rangeEnd.Length == 0)
            {
                return 0;
            }

            do
            {
                do
                {
                    if (arrayToSearch[i] >= rangeStart[j] && arrayToSearch[i] <= rangeEnd[j])
                    {
                        numb++;
                    }

                    i++;
                }
                while (i < startIndex + count);

                j++;
                i = startIndex;
            }
            while (j < rangeEnd.Length);

            return numb;
        }
    }
}
