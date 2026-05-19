class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        Console.WriteLine();
        
        MathAssignment mathAssignment = new("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment writingAssignment = new("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}