internal class Program
{
    private static void Main(string[] args)
    {
        //Напаишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
    Console.WriteLine("Введите число 1");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число 2");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число 3");
    int number3 = Convert.ToInt32(Console.ReadLine());
        if (number1 > number2 && number1 > number3)
        {
            Console.WriteLine($"Максимальное число {number1}");
        }
        else if (number2 > number1 && number2 > number3)
        {
            Console.WriteLine($"Максимальное число {number2}");
        }
        else if (number3 > number1 && number3 > number1)
        {
            Console.WriteLine($"максимальное число {number3}");

        }
        else
        {
            Console.WriteLine("Они все равны!");
        }
      
    }
}