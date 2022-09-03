//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
//  2 4 | 3 4
//  3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine ("Введите количество строк 1 матрицы");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов 1 матрицы");
int columns1 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите количество строк 2 матрицы");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите количество столбцов 2 матрицы");
int columns2 = Convert.ToInt32 (Console.ReadLine());

int  [,] firstMatrix = new int [rows1,columns1];
FillArray(firstMatrix);
Console.WriteLine($"Первая матрица:");
PrintArray(firstMatrix);

int[,]secondMatrix=new int [rows2,columns2];
FillArray(secondMatrix);
Console.WriteLine($"Вторая матрица:");
PrintArray(secondMatrix);

int[,] resultMatrix = MultiplyMatrix(firstMatrix, secondMatrix);
Console.WriteLine("Результирующая матрица равна:");
PrintArray(resultMatrix);

int[,] MultiplyMatrix (int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] result = new int [firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            for(int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                result[i,j] = result[i,j] + firstMatrix[i,k] * secondMatrix[k,j];
            }
        }
    }
    return result;
}
void FillArray(int[,]array)
{
    for (int i =0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            array[i,j]=new Random().Next(1,10);
        }
    }
}
void PrintArray(int [,]array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}