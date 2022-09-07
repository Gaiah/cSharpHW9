// //Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// //M = 1; N = 15 -> 120
// //M = 4; N = 8. -> 30


System.Console.WriteLine("Input M:");
int numberM = int.Parse(Console.ReadLine()!);
numberM = Math.Abs(numberM);

System.Console.WriteLine("Input N:");
int numberN = int.Parse(Console.ReadLine()!);
numberN = Math.Abs(numberN);

int finalSum = 0;

string NumbersToN(int start, int end, int sum)
{
    sum += start;
    if (start == end) 
    {
        return sum.ToString();        
    }    
    return NumbersToN(start + 1, end, sum);
}

System.Console.WriteLine($" From {numberM} to {numberN} numbers sum = {NumbersToN(numberM, numberN, finalSum)}");
