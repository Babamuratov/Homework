Console.Write("Введите число N: ");
int a = Convert.ToInt32(Console.ReadLine());

int b = 2;

if(a > 1)
{
    while(b <= a)
    {
        Console.Write(b + " ");
        b = b +2;
    }
}