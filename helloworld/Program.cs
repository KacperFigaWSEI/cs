namespace helloworld;

class Program
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            Console.WriteLine("Podaj liczbe: ");
            int x = int.Parse(Console.ReadLine());

            if (x < 2 || !isPrime(x)) Console.WriteLine("NIE");
            else Console.WriteLine("TAK");
        }
      
    }

    static bool isPrime(int n) {
        for (int i = 2; i <= Math.Sqrt(n); i++){
            if (n % i == 0){
                return false;
            }
        }
        return true;
    }

}
