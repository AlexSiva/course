namespace IfStatements
{
    public static class Task13
    {
        public static int DoSomething(bool b, int i)
        {
            if ((i < -8 || (i >= -4 && i < 0)) && b)
            {
                return 5 + i;
            }

            if (i > 0 && i <= 3 && b)
            {
                return i - 5;
            }

            if (i == 0 && b)
            {
                return 10;
            }

            if (i > 3 && b)
            {
                return i * (-1);
            }

            if (!b)
            {
                if ((i <= -5) || (i > 5))
                {
                    return i * (-1);
                }

                if (i > -5 && i <= 5)
                {
                    return 10 - i;
                }
            }

            return i;
        }
    }
}
