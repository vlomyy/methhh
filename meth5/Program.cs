// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите размерность квадтратной матрицы");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, m];
Random rnd = new Random();
Console.WriteLine("Исходная матрица:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m-1; j++)
    {
        array[j, i] = rnd.Next(-20, 20);
        Console.Write(array[j, i]+"\t");
    }

    Console.WriteLine();
}
Console.WriteLine("Новая матрица");
int[,] newarr = porz(array,m);
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m-1; j++)
    {
        array[i, j] = rnd.Next(-20, 20);
        Console.Write(newarr[j, i]+"\t");
    }
    Console.WriteLine();
}


static int[,] porz(int[,] arr,int razm)
{
    int z=0;
    for (int j = 0; j < razm; j++)
    {
        if (j % 2 == 0)
        {
            for (int i1 = 0; i1 < razm - 1; i1++) //проверка по количеству итераций
            {
                for (int i2 = 0; i2 < razm - 1; i2++) //проверка по элементам
                {
                    if (arr[i2 + 1, j] < arr[i2, j])
                    {
                        z = arr[i2 + 1, j];
                        arr[i2 + 1, j] = arr[i2, j];
                        arr[i2, j] = z;
                    }
                }
            }
        }
        else
        {
            for (int i1 = 0; i1 < razm - 1; i1++)
            {
                for (int i2 = 0; i2 < razm - 1; i2++)
                {
                    if (arr[i2 + 1, j] > arr[i2, j])
                    {
                        z = arr[i2 + 1, j];
                        arr[i2 + 1, j] = arr[i2, j];
                        arr[i2, j] = z;
                    }
                }
            }
        }
    }
    return arr;
}


