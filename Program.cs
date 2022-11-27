// TASK 25

/*Console.WriteLine("Enter the number A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Number B");
int B = Convert.ToInt32(Console.ReadLine());

var Result = Math.Pow(A, B);

Console.WriteLine($"The Result is {Math.Pow(A,B)}");*/

// TASK 27

/*Console.WriteLine("Enter the number");
int Number = Convert.ToInt32(Console.ReadLine());
int SumDigit(int Number)
{
    int counter = Convert.ToString(Number).Length;
    int SumDigit = 0;
    int result = 0;
    for (int i = 0; i < counter; i++)
    {
        SumDigit = Number - Number % 10;
        result = result + (Number - SumDigit);
        Number = Number / 10;
    }
    return result;
}
int sumDigit = SumDigit(Number);
Console.WriteLine($"The sum of digits in a number - {sumDigit}");*/

// TASK 29

int[] array = new int[8];

Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,1500);
    Console.Write(array[i]);

    if (i < array.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.Write("]");