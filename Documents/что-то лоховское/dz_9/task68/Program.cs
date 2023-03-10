// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных 
// числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Function(int m, int n)
{
    if (m == 0)
    return n + 1;
    else if ((m != 0) && (n == 0))
    return Function(m - 1,1);
    else return Function(m - 1, Function(m, n - 1));
}
Console.WriteLine("Введите числа m и n: ");
int m =  Convert.ToInt32(Console.ReadLine());
int n =  Convert.ToInt32(Console.ReadLine());

int res = Function(m, n);
Console.WriteLine($"A({m},{n}) = {res}");