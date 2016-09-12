namespace _02.EnterNumbers
{
    class MainClass
    {
        public static void Main()
        {
            EnterNumbers numbers = new EnterNumbers();

            int start = 1;

            for (int i = 0; i < 10; i++)
            {
                int currentNum = numbers.ReadNumber(start, 100);

                if (currentNum > start)
                {
                    start = currentNum;
                }
            }
        }
    }
}