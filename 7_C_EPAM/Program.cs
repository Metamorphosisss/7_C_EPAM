using _7_C_EPAM;

internal class Program
{
    static void Main(string[] args)
    {
        Automobile[] automobiles = { new Car ("car1", 200, 4), new Vehicle ("vehicle1", 150, 5) };
        Console.WriteLine("бiльша швидкiсть у -->");
        automobiles[0].CompareSpeed(automobiles[1]).ShowMoreInfo();
    }
}