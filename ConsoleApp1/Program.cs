class Zad
{
    static void Main(string[] args)
    {
        double BMI, m, w;
        Console.WriteLine("Podaj swoją wagę w kilogramach: ");
        m = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj swój wzrost w metrach: ");
        w = double.Parse(Console.ReadLine());
        BMI = m / (Math.Pow(w, 2));
        Console.WriteLine("Twoje BMI wynosi: " + BMI);
        Console.ReadKey();
    }
}