Console.Write("Введите число: ");
int CurNum = 1; 
int N = Convert.ToInt32(Console.ReadLine());

while(CurNum<=N)
{
    if(CurNum%2==0)
    {
        Console.WriteLine(CurNum);
        CurNum = CurNum+1;
    }
    else
    {
        CurNum = CurNum+1;
    }  
}