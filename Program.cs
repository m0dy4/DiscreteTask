namespace project_1_prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, i, j, f;

            Console.Write("Enter first number : ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter second number : ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Prime numbers between " + "{0} and {1} are: ", x, y);

            for (i = x; i <= y; i++)
            {
                if (i == 1 || i == 0)
                    continue;
                f = 1;
                for (j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        f = 0;
                        break;
                    }
                }
                if (f == 1)
                    Console.WriteLine(i);
            }
        }
    }
}
