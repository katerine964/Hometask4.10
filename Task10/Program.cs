// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вторая цифра числа: "+(n/10)%10);
