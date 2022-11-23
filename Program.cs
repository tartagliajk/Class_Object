namespace Klass_och_objekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person.Elev Filippa = new (18, "Filippa", 0, "F");
            Person.Teacher Steffan = new(40, "Steffan", 90, "Engelska");

            Fordon.Car V60 = new("Volvo", "V60", 2010, 200);
            Fordon.Motorcycle XSR125 = new("Yamaha", "XSR125", 2024);

            Former.Kvadrat Perfect = new(5);
            Former.Triangel Sne = new(20, 15,"Trubbig");
            Former.Cirkel Rund = new(10);

            Order Bok = new("No Longer Human", 12321, 1, 200, 200);

            Console.WriteLine(Bok.product);
        }
    }
}