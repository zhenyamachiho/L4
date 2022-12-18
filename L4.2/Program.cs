int GetNumber(string message)
{
bool isCorrect = false;
int result = 0;

while(!isCorrect)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out result))
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


  int SumNumber(int number)
  {
    
    int counter = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = number - number % 10;
      result = result + (number - advance);
      number = number / 10;
    }
   return result;
  }

int number = GetNumber("Введите число");
int sum = SumNumber(number);
Console.WriteLine(sum);