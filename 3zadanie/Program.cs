Console.Write("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());

if(Num%2==0)
{
    Console.Write(Num);
    Console.Write("   -Является четным числом");
}
else
{
    Console.Write(Num);
    Console.Write("   -Является нечетным числом");
}