namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length: ");
            var length = int.Parse(Console.ReadLine());

            var numbers = GetFilledList(length);
            var baseNumbers = new List<int>();
            foreach (var num in numbers)
            {
                var count = 0;
                for (int j = 1; j <= num; j++)
                {
                    if (num % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    baseNumbers.Add(num);
                }
            }
            baseNumbers.Sort();
            foreach (var number in baseNumbers)
            {
                Console.Write($"{number} ");
            }
        }
        public static List<int> GetFilledList(int length)
        {
            var numbers = new List<int>();
            var elements = 0;
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{i + 1}: ");
                elements = int.Parse(Console.ReadLine());
                numbers.Add(elements);

            }
            return numbers;
        }
    }
}