class Program
{

    static List<int> ReadValidScore()
    {
        int score;
        List<int> scores = new List<int>(5);
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter score (0-100): ");
            if (int.TryParse(Console.ReadLine(), out score) && score >= 0 && score <= 100)
            {
                scores.Add(score);
            }
            else
                Console.WriteLine("Invalid score. Try again.");
        }
        return scores;
    }
    static double CalculateAverage(List<int> scores)
    {
        int sum = 0;

        foreach (int score in scores)
            sum += score;
        return (double)sum / scores.Count;
    }
    static string DetermineGrade(double avg)
    {
        var grade = avg switch
        {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            >= 60 => "D",
            _ => "F"
        };
        return grade;
    }




    static void PrintReport(List<int> scores, string grade)
    {
        double avg = CalculateAverage(scores);
        Console.WriteLine("Scores: " + string.Join(", ", scores));
        Console.WriteLine($"Average: {avg:F2}");
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine(avg >= 60 ? "PASS" : "FAIL");
    }

    static void Main()
    {
        var scores = ReadValidScore();
        var grade = DetermineGrade(CalculateAverage(scores));
        PrintReport(scores, grade);
    }
}

