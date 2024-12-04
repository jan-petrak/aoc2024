namespace aoc2024.Day1;

public static class Day1
{
    public static void Solve()
    {
        var filePath = Path.GetFullPath(Path.Combine("Day1", "input.txt"), AppContext.BaseDirectory);

        List<int> firstColumn = [];
        List<int> secondColumn = [];

        foreach (var line in File.ReadLines(filePath))
        {
            var row = line.Split([' '], StringSplitOptions.RemoveEmptyEntries);

            firstColumn.Add(int.Parse(row[0]));
            secondColumn.Add(int.Parse(row[1]));
        }

        firstColumn.Sort();
        secondColumn.Sort();

        var result = firstColumn.Zip(secondColumn).Sum(x => Math.Abs(x.First - x.Second));

        Console.WriteLine(result);
    }
}

