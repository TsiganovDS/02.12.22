Console.Write("Введите количество строк: ");
int Row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int Col = Convert.ToInt32(Console.ReadLine());

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



int[,] array = new int[Row, Col];
generate2DArray(array);
print2dArray(array);

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1}  строкa с наименьшей суммой  элементов - {sumLine}");


int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}
