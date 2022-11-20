// Урок 9. Как не нужно писать код. Часть 3
//Показать натуральные числа от M до N, N и M заданы

string numbers(int M, int N)
{
    if (M == N + 1) return string.Empty;
    else return numbers(M, N - 1) + " " + N;
}

Console.WriteLine(numbers(1, 10));


//Найти сумму элементов от M до N, N и M заданы


int sum(int M, int N)
{
    if (M == N) return N;
    else return N + sum(M, N - 1);
}

Console.WriteLine(sum(1, 10));


//Написать программу вычисления функции Аккермана

int Akkerman(int a, int b)
{
    if (a == 0) return b + 1;
    else
      if (a != 0 && b == 0) return Akkerman(a - 1, 1);
    else return Akkerman(a - 1, Akkerman(a, b - 1));
}

Console.WriteLine(Akkerman(3, 5));


//Написать программу возведения числа А в целую стень B

int Pow(int A, int B)
{
    if (B == 1) return A;
    else return A * Pow(A, B - 1);
}

Console.WriteLine(Pow(3, 4));


//Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

string ShowFibonacci(int a, int b, int n)
{
    if (n == 0) return string.Empty;
    else return a + " " + ShowFibonacci(b, a + b, --n);
}

Console.WriteLine(ShowFibonacci(1, 5, 8));
