
int a = new Random().Next(1000);

Console.Write($"digits in {a}={DigitsCount(a)}");

int DigitsCount(int _a)
{
    int k = 0;
    while (_a > 0)
    {
        _a /= 10;
        k++;
    }
    return k;
}