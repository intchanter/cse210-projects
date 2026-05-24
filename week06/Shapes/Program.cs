class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape> {
            new Square("blue", 5),
            new Rectangle("green", 5, 7),
            new Circle("yellow", 2.5),
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()} shape has area {shape.GetArea()}");
        }
    }
}