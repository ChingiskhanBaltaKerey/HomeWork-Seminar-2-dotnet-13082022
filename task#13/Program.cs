// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> No
// 32679 -> 6

int a = 645;
if (a > 99)
{
int n = a % 10;     
Console.WriteLine (n);
} 
else 
Console.WriteLine ("No 3rd number");
int b = 78;
if (b > 99) 
{
int n1 = b % 10;
Console.Writeline (n1);
}
else 
Console.Writeline ("No 3rd number");
int c = 32679; 
if (c > 99)
{ 
int n2 = (c / 100) % 10;
Console.Writeline (n2);
}
else 
Console.WriteLine ("No 3rd number");

