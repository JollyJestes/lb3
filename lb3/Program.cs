//995 962  1018 962
class Lab995
{
    // Задана матрица размером n × m.
    // Найти максимальный по модулю элемент матрицы.
    // Переставить строки и столбцы матрицы таким образом,
    // чтобы максимальный по модулю элемент был расположен
    // на пересечении k-й строки и k-го столбца.

    public static void Run()
    {
        Console.WriteLine("Лабораторная работа 995");
        
        
        Console.WriteLine("Задайте размерности матрицы n ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Задайте размерности матрицы m ");
        int m = int.Parse(Console.ReadLine());

        
        int[,] matrix = new int[n, m];
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = random.Next(-100, 101); // Генерация случайных чисел от -100 до 100
            }
        }

       
        int maxAbsoluteValue = 0;
        int maxAbsoluteValueRowIndex = 0;
        int maxAbsoluteValueColIndex = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                int absoluteValue = Math.Abs(matrix[i, j]);
                if (absoluteValue > maxAbsoluteValue)
                {
                    maxAbsoluteValue = absoluteValue;
                    maxAbsoluteValueRowIndex = i;
                    maxAbsoluteValueColIndex = j;
                }
            }
        }

       
        int[,] rearrangedMatrix = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                rearrangedMatrix[i, j] = matrix[i, j];
            }
        }

       
        int[] tempRow = new int[m];
        for (int j = 0; j < m; j++)
        {
            tempRow[j] = rearrangedMatrix[maxAbsoluteValueRowIndex, j];
            rearrangedMatrix[maxAbsoluteValueRowIndex, j] = rearrangedMatrix[maxAbsoluteValueColIndex, j];
            rearrangedMatrix[maxAbsoluteValueColIndex, j] = tempRow[j];
        }

       
        int[] tempCol = new int[n];
        for (int i = 0; i < n; i++)
        {
            tempCol[i] = rearrangedMatrix[i, maxAbsoluteValueColIndex];
            rearrangedMatrix[i, maxAbsoluteValueColIndex] = rearrangedMatrix[i, maxAbsoluteValueRowIndex];
            rearrangedMatrix[i, maxAbsoluteValueRowIndex] = tempCol[i];
        }

        
        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

       
        Console.WriteLine("\nПереставленная матрица:");
        PrintMatrix(rearrangedMatrix);
    }

   
    static void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}


class Lab1018
{
    //Дан Двумерный массив. Определить:
   // а) количество максимальных элементов в массиве;
  //б) количество минимальных элементов в массиве.

    public static void Run()
    {
        Console.WriteLine("Лабораторная работа 1018");
        Console.WriteLine("Задайте размерности матрицы n ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Задайте размерности матрицы m ");
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = random.Next(100);
            }
        }

        
        int max = matrix[0, 0];
        int min = matrix[0, 0];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                }
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                }
            }
        }

       
        int countMax = 0;
        int countMin = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == max)
                {
                    countMax++;
                }
                if (matrix[i, j] == min)
                {
                    countMin++;
                }
            }
        }

       
        Console.WriteLine("Количество максимальных элементов: {0}", countMax);
        Console.WriteLine("Количество минимальных элементов: {0}", countMin);
    }
}

class Lab962
{
    //В зрительном зале 25 рядов,
    //в каждом из которых 36 мест (кресел).
    //Информация о проданных билетах хранится в Двумерном массиве,
    //номера строк которого соответствуют номерам рядов, а номера столбцов — номерам мест.
    //Если билет на то или иное место продан, то соответствующий элемент массива имеет значение 1,
    //в противном случае — 0. Составить программу, определяющую число проданных билетов на места в 12-м ряду.

    public static void Run()
    {
        Console.WriteLine("Лабораторная работа 962");
        
        int[,] tickets = new int[25, 36];
        tickets[11, 11] = 1;

        
        int soldTickets = 0;
        for (int i = 0; i < tickets.GetLength(0); i++)
        {
            soldTickets += tickets[i, 11];
        }

       
        Console.WriteLine("Число проданных билетов в 12-м ряду: {0}", soldTickets);
    }
}

class Program
{
    static void Main()
    {
       
      // Lab995.Run();
      // Lab1018.Run();
      // Lab962.Run();
    
    }
}