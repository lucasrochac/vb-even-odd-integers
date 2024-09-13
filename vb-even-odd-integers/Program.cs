
public static class MainClass
{
    public static void Main(string[] args)
    {
        List<int> original = new List<int>();
        List<int> odds = new List<int>();
        List<int> evens = new List<int>();

        Random random = new Random();

        for (int i = 0; i < 10; i++)
        {
            var num = random.Next(1, 51);
            original.Add(num);

            if (num % 2 == 0)
            {
                evens.Add(num);
            }
            else
            {
                odds.Add(num);
            }
        }

        Console.WriteLine(string.Format("Original: {0}", string.Join(", ", original)));
        Console.WriteLine(string.Format("Even: {0}", string.Join(", ", evens)));
        Console.WriteLine(string.Format("Odds: {0}", string.Join(", ", odds)));
    }
}
