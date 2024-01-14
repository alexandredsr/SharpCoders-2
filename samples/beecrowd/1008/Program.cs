
class Program
{
    static void Main(string[] args)
    {
        int numero = Convert.ToInt32(Console.ReadLine());
        int horas = Convert.ToInt32(Console.ReadLine());
        double s = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
    
        Console.WriteLine($"NUMBER = {numero}");
        Console.WriteLine($"SALARY = U$ {(horas * s).ToString("0.00")}");
    }
}