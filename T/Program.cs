// При описании рекурсии важно сделать правильный выход из нее
// Задача 1. Собрать строку с числами от а до b a<=b
// интегративный метод - заканчивается название метода на FOR
// рекурсивный метод - заканчивается название метода на REC

string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}
Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec(1, 10));


// для убывания
string NumbersForDown(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRecDown(int a, int b)
{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
    else return String.Empty;
}
Console.WriteLine(NumbersForDown(1, 10));
Console.WriteLine(NumbersRecDown(1, 10));

// Задача 2. Найти сумму чисел от 1 до n
int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}
int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}
Console.WriteLine(SumFor(10)); //55
Console.WriteLine(SumRec(10)); //55

// Задача 3. Факториал числа
int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}
// рекурсивный подход
int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}
Console.WriteLine(FactorialFor(10)); // 3628800
Console.WriteLine(FactorialRec(10)); // 3628800

// Задача 4. Возвести число А в степени n
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n)
{
    // return n == 0 ? 1 : PowerRec(a, n - 1) * a; (это 86+87 строка в короткой записи)
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;

}
Console.WriteLine(PowerFor(2, 10)); // 1024
Console.WriteLine(PowerRec(2, 10)); // 1024

// Базовая математика
// 2^28=(2^14)^2= ([2^7]^2)^2={1}=(([2^6*2^1]^2)^2)={2}=([(2^3)^2*2^1]^2)^2)={1}= 268 435 456 т.о. 6 операций
// т.о. улучшим задачу 4

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}
Console.WriteLine(PowerRecMath(2, 10)); // 1024

