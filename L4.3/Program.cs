//int[] array = {1, 2, 3, 4, 5, 6, 7, 8};

//for (int i = 0; i < array.Length; i++)
//{
//    Console.Write($"{array[i]} ");
//}

int[] GetMassiv ()
{
int[] massiv = new int[8];
Random rnd = new Random();
for (int i = 0; i < massiv.Length; i++)
{
massiv[i] = rnd.Next(0,10);
}

return massiv;
}
int[] array = GetMassiv();

for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]} ");
}