// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n>99)
    Console.WriteLine("Третья цифра: "+n.ToString()[2]);
else
{
    Console.WriteLine("третьей цифры нет");
}
