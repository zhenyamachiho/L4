int GetNumber(string message)
{
bool isCorrect = false;
int result = 0;

while(!isCorrect)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out result) && result > 0)
{
isCorrect = true;
}
else
{
Console.WriteLine("Ввели не число. Введите число.");
}
}

return result;
}

double GetPow(int a, int b)
{
   return Math.Pow(a, b);
}

int a = GetNumber("Введите число: ");
int b = GetNumber("Введите степень: ");

Console.WriteLine($"{GetPow(a, b)}");


