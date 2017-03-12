namespace _02.Max_Method
{
    using System;

    public class MethodMax
    {
        public static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int result = GetMax(firstNum, secondNum, thirdNum);
            Console.WriteLine(result);
        }

        public static int GetMax (int firstNum, int secondNum, int thirdNum)
        {
            if (firstNum < secondNum && firstNum < thirdNum)
            {
                return firstNum;
            }
            else if (secondNum < firstNum && secondNum < thirdNum)
            {
                return secondNum;
            }
            return thirdNum;

        }
    }
}
