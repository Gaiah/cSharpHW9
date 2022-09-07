//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29


System.Console.WriteLine("Input aM:");
int aM = int.Parse(Console.ReadLine()!);
aM = Math.Abs(aM);

System.Console.WriteLine("Input aN:");
int aN = int.Parse(Console.ReadLine()!);
aN = Math.Abs(aN);

//                                              Ackermann function   A(m, n)

//          if m = 0 ->           ----->        A(m, n) = n + 1
//          if m > 0, n = 0       ----->        A(m, n) = A(m - 1, 1)
//          if m > 0, n > 0       ----->        A(m, n) = A(m - 1, A(m, n - 1))


int Ackermann(int akkerM, int akkerN)
{
    
    if (akkerM == 0) 
    {
        akkerN += 1;
        return akkerN;        
    }  
    if (akkerN == 0 && akkerM != 0)
    {
        return Ackermann(akkerM - 1, 1);
    }
    if (akkerM > 0 && akkerN > 0)
    {
        return Ackermann(akkerM -1, Ackermann(akkerM, akkerN - 1));        
    }
    return Convert.ToInt32(Ackermann(akkerM, akkerN));
}

System.Console.WriteLine($" A({aM}, {aN}) = {Ackermann(aM, aN)}");
