class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Address jackAddress = new("123 Nimble St.", "Bangor", "ME", "US");
        Customer jack = new("Jack Nimble", jackAddress);
        Order jackOrder = new(jack);
        jackOrder.AddProduct(new Product("Wax Candle", "CND1", 0.50f, 12));
        jackOrder.AddProduct(new Product("Golden Menorah", "MNR1", 12.50f, 1));
        jackOrder.AddProduct(new Product("Box of 100 Matches", "MTC100", 1.50f, 1));

        Console.WriteLine("Jack's shipping label:");
        Console.WriteLine(jackOrder.GetShippingLabelText());
        Console.WriteLine();
        Console.WriteLine("Jack's packing label:");
        Console.WriteLine(jackOrder.GetPackingLabelText());
        Console.WriteLine();
        Console.WriteLine($"Jack's subtotal: {jackOrder.GetSubtotal():C2}");
        Console.WriteLine($"Jack's shipping: {jackOrder.GetShipping():C2}");
        Console.WriteLine($"Jack's total: {jackOrder.GetTotal():C2}");
        Console.WriteLine();
        Console.WriteLine();
        
        Address jillAddress = new("456 Hill Rd.", "Montreal", "QC", "CA");
        Customer jill = new("Jill Hill", jillAddress);
        Order jillOrder = new(jill);
        jillOrder.AddProduct(new Product("Tin Pail", "TPL1", 7.50f, 1));
        jillOrder.AddProduct(new Product("1 Gallon Distilled Water", "WTR1", 1.20f, 3));
        jillOrder.AddProduct(new Product("Box of 100 Matches", "MTC100", 1.50f, 1));

        Console.WriteLine("Jill's shipping label:");
        Console.WriteLine(jillOrder.GetShippingLabelText());
        Console.WriteLine();
        Console.WriteLine("Jill's packing label:");
        Console.WriteLine(jillOrder.GetPackingLabelText());
        Console.WriteLine();
        Console.WriteLine($"Jill's subtotal: {jillOrder.GetSubtotal():C2}");
        Console.WriteLine($"Jill's shipping: {jillOrder.GetShipping():C2}");
        Console.WriteLine($"Jill's total: {jillOrder.GetTotal():C2}");
    }
}