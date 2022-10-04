// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите цифру");
int n = Convert.ToInt32(Console.ReadLine());
if (n>=1 && n<=7)
{
    if(n<6)
    {
       Console.WriteLine("нет"); 
    }
    else
    {
        Console.WriteLine("да");
    }
}
else
{
    Console.WriteLine("Такого дня недели нет");
}
