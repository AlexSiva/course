namespace IfStatements
{
    public static class Task14
    {
        public static int DoSomething(bool b1, bool b2, int i)
        {
            if (((i <= -5) || (i > 5)) && b1 && b2)
            {
                return 10 - (i * 2);
            }

            if ((i > -5) && (i <= 5) && b1 && b2)
            {
                return i * (-2);
            }

            if (((i <= -5) || (i > 5)) && b1 && !b2)
            {
                return i * i * i;
            }

            if (((i > 7) || (i < -9)) && !b1 && b2)
            {
                return i * (-1);
            }

            if ((i > -5) && (i <= 5) && b1 && !b2)
            {
                return i * i;
            }

            if ((i >= -7) && (i < -3) && !b1 && b2)
            {
                return i * 10;
            }

            if (((i > 7) || (i < -9)) && !b1 && !b2)
            {
                return i * (-1);
            }

            if (i == 0 && !b1 && !b2)
            {
                return 0;
            }

            if (((i >= -3 && i < 0) || (i > 0 && i < 5)) && !b1 && !b2)
            {
                return i * (-100);
            }

            return i;
        }
    }
}
