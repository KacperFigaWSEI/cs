namespace helloworld;

class Program
{
    static void Main(string[] args)
    {
        int a, b, c;

        do
        {
            Console.WriteLine("Wpisz liczbe niewieksza niz 100");
            a = int.Parse(Console.ReadLine());
        } while (a > 100);

        do
        {
            Console.WriteLine("Wpisz liczbe niewieksza niz 100");
            b = int.Parse(Console.ReadLine());
        } while (b > 100);

        do
        {
            Console.WriteLine("Wpisz liczbe niewieksza niz 100");
            c = int.Parse(Console.ReadLine());
        } while (c > 100);

        Console.WriteLine(a + b + c);
    }

}

