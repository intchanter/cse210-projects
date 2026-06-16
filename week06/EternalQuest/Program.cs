// Enhancements:
// * Used Json Lines format for saving the current score and each goal.
// * Implemented polymorphic serialization and deserialization using
//   JsonSerializer.
// * Added levels based on 100 * triangle numbers.

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new();
        manager.Start();
    }
}