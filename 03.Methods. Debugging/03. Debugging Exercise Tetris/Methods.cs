namespace _03.Debugging_Exercise_Tetris
{
    using System;

    public class Methods
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string currentDirection = Console.ReadLine();

            while (currentDirection != "exit")
            {
                switch (currentDirection)
                {
                    case "left":
                        Left(n);
                        break;
                    case "down":
                        Down(n);
                        break;
                    case "right":
                        Right(n);
                        break;
                    case "up":
                        Up(n);
                        break;
                }

                currentDirection = Console.ReadLine();
            }
        }

        public static void Left(int numberL)
        {
            for (int i = 0; i < numberL; i++)
            {
                Console.WriteLine(new string('.', numberL) + new string('*', numberL));
            }

            for (int i = 0; i < numberL; i++)
            {
                Console.WriteLine(new string('*', 2 * numberL));
            }

            for (int i = 0; i < numberL; i++)
            {
                Console.WriteLine(new string('.', numberL) + new string('*', numberL));
            }
        }

        public static void Right(int numberR)
        {
            for (int i = 0; i < numberR; i++)
            {
                Console.WriteLine(new string('*', numberR) + new string('.', numberR));
            }

            for (int i = 0; i < numberR; i++)
            {
                Console.WriteLine(new string('*', 2 * numberR));
            }

            for (int i = 0; i < numberR; i++)
            {
                Console.WriteLine(new string('*', numberR) + new string('.', numberR));
            }
        }

        public static void Up(int numberUp)
        {
            for (int i = 0; i < numberUp; i++)
            {
                Console.WriteLine(new string('.', numberUp) + new string('*', numberUp) + new string('.', numberUp));
            }

            for (int i = 0; i < numberUp; i++)
            {
                Console.WriteLine(new string('*', numberUp * 3));
            }
        }

        public static void Down(int numberDown)
        {
            for (int i = 0; i < numberDown; i++)
            {
                Console.WriteLine(new string('*', numberDown * 3));
            }
            
            for (int i = 0; i < numberDown; i++)
            {
                Console.WriteLine(new string('.', numberDown) + new string('*', numberDown) + new string('.', numberDown));
            }
        }
    }
}
