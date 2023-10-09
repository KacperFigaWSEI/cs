namespace helloworld;

class Program
{
    static void Main(string[] args)
    {
        int _number;
        int num_of_zeros;

        do
        {
            Console.WriteLine("Podaj liczbę naturalną: ");

            _number = int.Parse(Console.ReadLine());
        } while ((_number <= 0));

        num_of_zeros = (_number.ToString().Length-1);

        double start_scope = 1;
        double end_scope = 10;

        if(num_of_zeros > 0)
        {
            char lastChar = _number.ToString()[_number.ToString().Length - 1];
            if (lastChar == '0')
            {
                start_scope = Math.Pow(10, num_of_zeros-1)+1;

                if (start_scope == 2)
                {
                    start_scope = 1;
                }

                end_scope = Math.Pow(10, num_of_zeros);
            }
            else {
                start_scope = Math.Pow(10, num_of_zeros) + 1;
                end_scope = (start_scope -1) * 10;
            }

        };

        Console.WriteLine(start_scope + " - " + end_scope);
    }

}
