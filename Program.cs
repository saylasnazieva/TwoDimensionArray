// Задача 47.Задайте двумерный массив размером m*n, заполненный случайными вещественными числами . m =3 , n = 4.
// 0,5,7,9,-0,2;    1 -3,38-9,9; 87,8-7,19.

//string[,] table = new string[3,4];
// table[0,0]  table[0,1]  table[0,2]  table[0,4]   
// table[1,0]  table[1,1]  table[1,2]  table[1,4]
/*
int[,] matrix = new int[3,4];

void PrintArray(int[,] matr)
{

for (int i =0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1) ; j++)
    {
        Console.Write($"{matrix[i,j]} ");
    }
Console.WriteLine();
   }
}

int[,] matrix = new int[3,4];
PrintArray( matrix);

void FILLArray(int[,] matr)
{
    for for (int i =0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1) ; j++)
    
    }
    
      {
        matr[i , j] = new Random().Next(1,100);
      }
}

int[,] matrix = new int[3,4];
PrintArray( matrix);
Console.WriteLine();
PrintArray(matrix);
*/

// Задача 50.Напишите программу,которая на вход принимает позиции элементов в двумерном массиве,и возвращает значение этого элемента или же указание,что такого элемента нет.
// Например , задан массив : 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// 17-> числа с такими индексами в массиве нет.
/*
int[,] PrintRandomArray(int rows , colums,numbers)
{
    int[,] array = new int[rows,colums];

    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            array[i,j] = new Random().Next(numbers + 1);
        }
    }
    return array;
}
Console.WriteLine();

void FILLArray(int[,] array)

{

    for (int i = 0; i < array.GetLength(0); i++)

    {

        for (int j = 0; j < array.GetLength(1); j++)

        {

            array[i, j] = new Random().Next(1, 10);
        }
    }
}

Console.WriteLine();
{
    if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1) )  Console.WriteLine(numbers[rows,colums]);
    else  Console.WriteLine($"{rows}{colums}-> There is no such number in the array");
}

int[,] PrintRandomArray(int rows , colums,numbers)
PrintRandomArray();
Console.WriteLine();
FILLArray();
*/

// Задача 52. Задайте двумерный массив из целых чисел . Найдите среднее арифметическое элементов в каждом столбце.
// Например , задан массив:
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// Среднее арефметическое каждого столбца : 4,6,: 5,6:3,6:3.
/*
int[,] array = new int[n,m];
PrintRandomArray(array);

double matrix = 0;
for (int i = 0; i < array.GetLength(0); i++)

    {

        for (int j = 0; j < array.GetLength(1); j++)
    }
{
    matrix=(matrix+array[i,j]);
}
matrix = matrix / n ;
Console.WriteLine();
PrintRandomArray(array);

void FILLRandomArray(int[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
     {
       for (int j = 0; j < array.GetLength(1); j++)
       {
        array[i,j]= new Random().Next(0,10);
       }
     }
}
Console.WriteLine(" ");
*/

