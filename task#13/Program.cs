// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> No
// 32679 -> 6

void Ex01 ()
{
int a = 645;
int a1 = a % 10;
Console.WriteLine (a1);
}
Ex01 ();
void Ex02 ()
{
    int b = 78;
    if (b > 99)
    {
        int b1 = b % 10;
        Console.WriteLine (b1);
    }
    else
    {
        Console.WriteLine ("No 3rd number");
    } 

}
Ex02 ();

void Ex03()
{
int c = 32679; 
if (c > 99)
{ 
int c1 = (c / 100);
int c2 = c1 % 10;
Console.WriteLine (c1);
}
else 
Console.WriteLine ("No 3rd number");
}
Ex03 ();

