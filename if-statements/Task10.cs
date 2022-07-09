namespace IfStatements
{
    public static class Task10
    {
        public static int DoSomething(bool b1, bool b2, int i)
        {
            if ((i >= -9) && (i <= -2) && b1 && b2)
            {
                return 5 + i;
            }

            if ((i >= 2) && (i <= 9) && b1 && b2)
            {
                return 10 - i;
            }

            if (i == 0 && b1 && b2)
            {
                return -1;
            }

            if ((i >= -9) && (i <= -2) && b1 && !b2)
            {
                return 5 - i;
            }

            if ((i >= 2) && (i <= 9) && b1 && !b2)
            {
                return 10 + i;
            }

            if (i == 0 && b1 && !b2)
            {
                return -1;
            }

            if (((i >= 10) || (i <= -10)) && !b1 && b2)
            {
                return i + 1;
            }

            if (((i > -5 && i < 0) || (i > 0 && i < 5)) && !b1 && b2)
            {
                return i + 10;
            }

            if (i == 0 && !b1 && b2)
            {
                return 1;
            }

            if (((i >= 10) || (i <= -10)) && !b1 && !b2)
            {
                return i - 1;
            }

            if (((i > -5 && i < 0) || (i > 0 && i < 5)) && !b1 && !b2)
            {
                return i - 10;
            }

            if (i == 0 && !b1 && !b2)
            {
                return -1;
            }

            return i;
        }
    }
}
