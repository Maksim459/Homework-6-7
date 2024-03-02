internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("введите высоту");
      double h=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("введите радиус");
      double r = Convert.ToDouble(Console.ReadLine());
        double sful = Cone.Class1.Sfull(h, r);
        double spov = Cone.Class1.Spov(r);
        Console.WriteLine("площадь полной поверхности конуса");
        Console.WriteLine(sful);
        Console.WriteLine("площадь боковой поверхности конуса");
        Console.WriteLine(spov);
    }
}