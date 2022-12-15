//-------------------------------------DZ4--------------------------------------------------------

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

/*
void Degree(int A, int B)
{
    int result = 1;
    for(int current = 1; current <= B; current++)
    {
        result = result * A;
    }
    Console.WriteLine($"Total: {result}");
}
Console.Write("Input number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
int B = Convert.ToInt32(Console.ReadLine());
Degree(A,B);
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int GetSum(int n)
{
    int Count = 0;
    int sum = 0;
    while(n > 0)
    {
        sum = sum + n % 10;
        n = n / 10;
        Count++;
    }
    return sum;
}
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = GetSum(num);
Console.WriteLine(result);

*/

//Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

int[] CreateArray(int size)
{
    int[] array = new int [size];
    
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input Value of {i + 1} element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

Console.Write("Input Array size: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(length);
ShowArray(myArray);

