public class Program
{
    public static void Main(string[] args)
    {
        string inputFilePath = "Data/input.txt";
        string outputFilePath = "Data/output.txt";
        Console.WriteLine("Please enter the number of wolves you want to input:");
        int numberOfWolves = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the wolf IDs separated by spaces:");
        List<int> wolfList = Console.ReadLine().Split().Select(int.Parse).ToList();


        if (wolfList.Count < 5 || wolfList.Count > 2 * Math.Pow(10, 5))
        {
            Console.WriteLine("Invalid input. The number of wolfs must be between 5 and 200,000.");
            wolfList = Console.ReadLine().Split().Select(int.Parse).ToList();

        }

        while (wolfList.Count != numberOfWolves)
        {
            Console.WriteLine("Invalid input. Please enter a valid number of wolves.");
            wolfList = Console.ReadLine().Split().Select(int.Parse).ToList();
        }

        foreach (int wolf in wolfList)
        {
            if (wolf < 1 || wolf > 5)
            {
                Console.WriteLine("Invalid input. Wolfs must have IDs between 1 and 5.");
                wolfList = Console.ReadLine().Split().Select(int.Parse).ToList();
            }
        }
        int result = Result.UniqueWolfs(wolfList);
        Console.WriteLine(result);
    }
}
