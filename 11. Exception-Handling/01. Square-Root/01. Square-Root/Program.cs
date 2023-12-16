namespace _01._Square_Root
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            try
            {
                if (n < 0)
                {
                    throw new Exception();
                }
                double squareRoot = Math.Sqrt(n);
                Console.WriteLine(squareRoot);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid number.");
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}