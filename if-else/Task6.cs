namespace IfStatements
{
    public static class Task6
    {
        public static int DoSomething(int i)
        {
            int result = 0;

            if (i < -8)
            {
                result = i * i;
            }
            else if (i >= 7)
            {
                return i * 2;
            }
            else if (i <= -2)
            {
                return i * 3;
            }
            else if (i > 3)
            {
                return i * (i - 1) * (-1);
            }
            else
            {
                return (i * 2) + (i * i);
            }

            return result;
        }
    }
}
