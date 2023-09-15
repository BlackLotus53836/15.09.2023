class Program
{
    static void Main()
    {
        // Создаем и заполняем массив
        int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };

        // Находим координаты наименьшего элемента
        int minElement = int.MaxValue;
        int minRow = -1;
        int minCol = -1;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < minElement)
                {
                    minElement = array[i, j];
                    minRow = i;
                    minCol = j;
                }
            }
        }

        // Создаем новый массив без строки и столбца с наименьшим элементом
        int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

        int newRow = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (i == minRow)
                continue;

            int newCol = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j == minCol)
                    continue;

                newArray[newRow, newCol] = array[i, j];
                newCol++;
            }

            newRow++;
        }

        // Выводим новый массив
        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            for (int j = 0; j < newArray.GetLength(1); j++)
            {
                Console.Write(newArray[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

