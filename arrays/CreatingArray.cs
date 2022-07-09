using System;

namespace WorkingWithArrays
{
    public static class CreatingArray
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
        public static int[] CreateEmptyArrayOfIntegers()
        {
            return new int[0];
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
        public static bool[] CreateEmptyArrayOfBooleans()
        {
            bool[] array = { };
            return array;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
        public static string[] CreateEmptyArrayOfStrings()
        {
            return new string[] { };
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Performance", "CA1825:Avoid zero-length array allocations", Justification = "Education purposes")]
        public static char[] CreateEmptyArrayOfCharacters()
        {
            return new char[] { };
        }

        public static double[] CreateEmptyArrayOfDoubles()
        {
            return Array.Empty<double>();
        }

        public static float[] CreateEmptyArrayOfFloats()
        {
            return Array.Empty<float>();
        }

        public static decimal[] CreateEmptyArrayOfDecimals()
        {
            return Array.Empty<decimal>();
        }

        public static int[] CreateArrayOfTenIntegersWithDefaultValues()
        {
            return new int[10];
        }

        public static bool[] CreateArrayOfTwentyBooleansWithDefaultValues()
        {
            return new bool[20];
        }

        public static string[] CreateArrayOfFiveEmptyStrings()
        {
            return new string[5];
        }

        public static char[] CreateArrayOfFifteenCharactersWithDefaultValues()
        {
            return new char[15];
        }

        public static double[] CreateArrayOfEighteenDoublesWithDefaultValues()
        {
            return new double[18];
        }

        public static float[] CreateArrayOfOneHundredFloatsWithDefaultValues()
        {
            return new float[100];
        }

        public static decimal[] CreateArrayOfOneThousandDecimalsWithDefaultValues()
        {
            return new decimal[1000];
        }

        public static int[] CreateIntArrayWithOneElement()
        {
            var array = new[] { 123_456 };
            return array;
        }

        public static int[] CreateIntArrayWithTwoElements()
        {
            var array = new[] { 1_111_111, 9_999_999 };
            return array;
        }

        public static int[] CreateIntArrayWithTenElements()
        {
            var array = new[] { 0, 4234, 3845, 2942, 1104, 9794, 923943, 7537, 4162, 10134 };
            return array;
        }

        public static bool[] CreateBoolArrayWithOneElement()
        {
            var array = new[] { true };
            return array;
        }

        public static bool[] CreateBoolArrayWithFiveElements()
        {
            var array = new[] { true, false, true, false, true };
            return array;
        }

        public static bool[] CreateBoolArrayWithSevenElements()
        {
            var array = new[] { false, true, true, false, true, true, false };
            return array;
        }

        public static string[] CreateStringArrayWithOneElement()
        {
            var array = new[] { "one" };
            return array;
        }

        public static string[] CreateStringArrayWithThreeElements()
        {
            var array = new[] { "one", "two", "three" };
            return array;
        }

        public static string[] CreateStringArrayWithSixElements()
        {
            var array = new[] { "one", "two", "three", "four", "five", "six" };
            return array;
        }

        public static char[] CreateCharArrayWithOneElement()
        {
            var array = new[] { 'a' };
            return array;
        }

        public static char[] CreateCharArrayWithThreeElements()
        {
            var array = new[] { 'a', 'b', 'c' };
            return array;
        }

        public static char[] CreateCharArrayWithNineElements()
        {
            var array = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'a' };
            return array;
        }

        public static double[] CreateDoubleArrayWithOneElement()
        {
            var array = new[] { 1.12 };
            return array;
        }

        public static double[] CreateDoubleWithFiveElements()
        {
            var array = new[] { 1.12, 2.23, 3.34, 4.45, 5.56 };
            return array;
        }

        public static double[] CreateDoubleWithNineElements()
        {
            var array = new[] { 1.12, 2.23, 3.34, 4.45, 5.56, 6.67, 7.78, 8.89, 9.91 };
            return array;
        }

        public static float[] CreateFloatArrayWithOneElement()
        {
            var array = new[] { 123456789.123456f };
            return array;
        }

        public static float[] CreateFloatWithThreeElements()
        {
            var array = new[] { 1000000.123456f, 2223334444.123456f, 9999.999999f };
            return array;
        }

        public static float[] CreateFloatWithFiveElements()
        {
            var array = new[] { 1.0123f, 20.012345f, 300.01234567f, 4000.01234567f, 500000.01234567f };
            return array;
        }

        public static decimal[] CreateDecimalArrayWithOneElement()
        {
            var array = new[] { 10000.123456m };
            return array;
        }

        public static decimal[] CreateDecimalWithFiveElements()
        {
            var array = new[] { 1000.1234m, 100000.2345m, 100000.3456m, 1000000.456789m, 10000000.5678901m };
            return array;
        }

        public static decimal[] CreateDecimalWithNineElements()
        {
            var array = new[] { 10.122112m, 200.233223m, 3000.344334m, 40000.455445m, 500000.566556m, 6000000.677667m, 70000000.788778m, 800000000.899889m, 9000000000.911991m };
            return array;
        }
    }
}
