using System;

namespace ArithmeticSequenceTask
{
    public static class ArithmeticSequence
    {
        /// <summary>
        /// Calculates the sum of the first 'count' elements of a sequence in which each element is the sum of the given integer 'number'
        /// and number of occurrences of the given integer 'add', based on the element's position within the sequence.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <param name="add">The term.</param>
        /// <param name="count">The number of occurrences.</param>
        /// <returns>Calculated sum.</returns>
        /// <exception cref="OverflowException">
        /// Thrown when number is int.MaxValue and term more then 0
        /// - or -
        /// number is int.MinValue and term less then 0.
        /// </exception>
        /// <exception cref="ArgumentException">Throw if count less than zero.</exception>
        public static int Calculate(int number, int add, int count)
        {
            int sum = 0, i = 0;
            if ((number is int.MaxValue && add > 0) || (number is int.MinValue && add < 0))
            {
                throw new OverflowException("The obtained result out of range of integer values.");
            }

            if (count < 0)
            {
                throw new ArgumentException("The count of elements of the sequence cannot be less or equals zero.", nameof(count));
            }

            while (i < count)
            {
                sum += number + (i * add);
                i++;
            }

            return sum;
        }
    }
}
