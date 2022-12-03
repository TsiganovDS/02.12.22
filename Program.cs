Console.Write("Введите количество строк: ");
int Row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int Col = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[Row, Col];

void generate2DArray(int[,] array)
{
    for (int i = 0; i < Row; i++)
    {
        for (int j = 0; j < Col; j++)
        {
            array[i, j] = new Random().Next(0,10);
        }
    }
}

 void print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Исходный массив: ");
generate2DArray(numbers);
print2dArray(numbers);
Console.WriteLine();
Console.WriteLine("Отсортированный массив: ");
OrderArrayLines(numbers);

void OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

print2dArray(numbers);

