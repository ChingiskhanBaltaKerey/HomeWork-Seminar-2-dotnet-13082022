//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

void Ex01 ()
{
int val1 = 456;
int a1 = val1 / 10;
int b1 = a1 % 10; 
Console.WriteLine (b1);
}
Ex01();

void Ex02 ()
{
    int val2 = 782;
    int a2 = val2 / 10;
    int b2 = a2 % 10;
    Console.WriteLine (b2);
}
Ex02();
void Ex03 ()
{
    int val3 = 918;
    int a3 = val3 / 10;
    int b3 = a3 % 10;
    Console.WriteLine (b3);

}
Ex03();