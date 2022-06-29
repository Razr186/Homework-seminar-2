internal class Program
{
    private static void Main(string[] args)
    {
        //Напаишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.
    Console.WriteLine("Введите число 1");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число 2");
    int number2 = Convert.ToInt32(Console.ReadLine());
    if (number1 > number2)
        {
            Console.WriteLine($"{number1} больше чем {number2}");
        }
        else if (number2 > number1)
        {
            Console.WriteLine($"{number2} больше чем {number1}");
        }
        else
        {
            Console.WriteLine("Они равны!");
        }
    }
}