class Program
{
    static void Main()
    {
        // Создаем и заполняем первую матрицу
        int[,] matrix1 = { { 2, 4 }, { 3, 2 } };

        // Создаем и заполняем вторую матрицу
        int[,] matrix2 = { { 3, 4 }, { 3, 3 } };

        // Проверяем, можно ли умножить матрицы
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
        {
            Console.WriteLine("Невозможно умножить матрицы!");
            return;
        }

        // Создаем результирующую матрицу
        int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

        // Находим произведение матриц
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        // Выводим результат
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
