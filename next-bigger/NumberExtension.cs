using System;

namespace NextBiggerTask
{
    public static class NumberExtension
    {
        /// <summary>
        /// Finds the nearest largest integer consisting of the digits of the given positive integer number and null if no such number exists.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>
        /// The nearest largest integer consisting of the digits  of the given positive integer and null if no such number exists.
        /// </returns>
        /// <exception cref="ArgumentException">Thrown when source number is less than 0.</exception>
        public static int? NextBiggerThan(int number)
        {
            int numb, count = 0, old = number, i = 0, min;
            string fuck = Convert.ToString(number, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            if (number < 0)
            {
                throw new ArgumentException($"Value of {nameof(number)} cannot be less zero.");
            }

            while (old > 0)
            {
                old /= 10;
                count++;
            }

            char[] newArray = new char[count];
            while (i < count)
            {
                newArray[i] = fuck[i];
                i++;
            }

            for (i = count - 1; i > 0; i--)
            {
                if (newArray[i] > newArray[i - 1])
                {
                    break;
                }
            }

            if (i == 0 || number == int.MaxValue)
            {
                return null;
            }

            min = i;
            numb = newArray[i - 1];
            for (int j = i + 1; j < count; j++)
            {
                if (newArray[j] > numb && newArray[j] < newArray[min])
                {
                    min = j;
                }
            }

            char temp = newArray[i - 1];
            newArray[i - 1] = newArray[min];
            newArray[min] = temp;
            Array.Sort(newArray, i, count - i);
            string txt = new string(newArray);
            number = int.Parse(txt, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            return number;
        }
    }
}
