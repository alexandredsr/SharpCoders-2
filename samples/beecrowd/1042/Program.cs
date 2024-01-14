class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o valor de 'a': ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de 'b': ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de 'c': ");
        int c = int.Parse(Console.ReadLine());

        if (a > b && a > c) {
            Console.WriteLine("Maior");
        }
        else if (!(a > b) && a > c || a > b && !(a > c)) {
            Console.WriteLine("Medio");
        }
        else {
            Console.WriteLine("Menor");
        }

        if (b > a && b > c) {
            Console.WriteLine("Maior");
        }
        else if (!(b > a) && b > c || b > a && !(b > c)) {
            Console.WriteLine("Medio");
        }
        else {
            Console.WriteLine("Menor");
        }

        if (c > b && c > a) {
            Console.WriteLine("Maior");
        }
        else if (!(c > b) && c > a || c > b && !(c > a)) {
            Console.WriteLine("Medio");
        }
        else {
            Console.WriteLine("Menor");
        }


        
    }

}