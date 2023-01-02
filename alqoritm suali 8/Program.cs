namespace alqoritm_suali_8;
class Program
{
    static void Main(string[] args)
    {
       
        
        int max = 0;
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        for (int i = 1; i < numbers.Length; i++)
        { if (numbers[i] > numbers[max])
             max = i;

        }

        Console.WriteLine(numbers[ max]);



    }
}

