namespace PracticeProject
{
    public class Exercise1Class
    {
        static void Main(string[] args)
        {
            // testing normal numbers
            Console.WriteLine(Multiply(5, 2));      // 10
            Console.WriteLine(Multiply(2, 5));      // 10
            Console.WriteLine(Multiply(5, 1));      // 5
            Console.WriteLine(Multiply(1, 5));      // 5

            // testing zeros
            Console.WriteLine(Multiply(0, 6));      // 0
            Console.WriteLine(Multiply(6, 0));      // 0
            Console.WriteLine(Multiply(0, 0));      // 0

            // testing negatives
            Console.WriteLine(Multiply(5, -2));     // -10
            Console.WriteLine(Multiply(-2, 5));     // -10
            Console.WriteLine(Multiply(-2, -2));    // 4
            Console.WriteLine(Multiply(-9, 2));     // -18
        }

        /// <summary>
        /// Takes two numbers and returns their multiplication.
        /// </summary>
        public static int Multiply(int firstNumber, int secondNumber)
        {
            if (firstNumber == 0 || secondNumber == 0) // If any number is 0, any number * 0 = 0
            {
                return 0;
            }

            var total = 0;

            // Multiplication is the same as multiple additions. Example: 4*2 = 4+4 (4 added to itself, 2 times)
            for (int i = 0; i < Math.Abs(secondNumber); i++)
            {
                total += firstNumber;
            }

            if (secondNumber < 0)
            {
                return -total;
            }
            else
            {
                return total;
            }
        }
    }
}