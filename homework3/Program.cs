internal class Program
{
    private static void Main(string[] args)
    {
        //Напаишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    int count = Math.Abs(number);
       if (Math.Abs(number) % 2 == 0)
        {
            Console.WriteLine($"{number} четное");
        }
        else
        {
            Console.WriteLine($"{number} нечетное");
        }
    }
}