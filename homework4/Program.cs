
internal class NewBaseType
{
    private static void Main(string[] args)
//Напишите программу, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N.
{
Console.WriteLine("_______________________________________");
Console.WriteLine("Введите число для вывода всех четных чисел от 1 до него");
int number = Convert.ToInt32(Console.ReadLine());
OurPower (number - number);

void OurPower(int curentnumber)
    {
        while (curentnumber <= number)
        {
        if (curentnumber % 2 == 0)
            {
                Console.WriteLine($"{curentnumber}    ");
            }
            curentnumber++;
        }
    }
}
}

