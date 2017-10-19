namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("how many numbers do you have? ");

            string strNumberCount =
                System.Console.ReadLine();

            int intNumberCount =
                System.Convert.ToInt32(strNumberCount);

            int[] intNumbers =
                new int[intNumberCount];

            for (int intIndexNumber = 1; intIndexNumber <= intNumberCount; intIndexNumber++)
            {
                string strMassege =
                    string.Format("[{0}] -> ", intIndexNumber);

                System.Console.Write(strMassege);

                string strNumber =
                    System.Console.ReadLine();

                int intNumber =
                    System.Convert.ToInt32(strNumber);

                intNumbers[intIndexNumber - 1] =
                    intNumber;
            }
            int intSum = 0;

            for (int intIndex = 0; intIndex <= intNumberCount - 1; intIndex++)
            {
                intSum +=
                    intNumbers[intIndex];
            }

            System.Console.Write("the sum of your number is: " + intSum);

            System.Console.ReadLine();
        }
    }
}
