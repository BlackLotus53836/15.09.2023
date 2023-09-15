class Program
{
    static void Main()
    {
        int n = 4; // Размер массива
        int[,] array = new int[n, n]; // Создаем массив

        int value = 1; // Значение, которое будем записывать в ячейки массива

        int top = 0; // Верхняя граница
        int bottom = n - 1; // Нижняя граница
        int left = 0; // Левая граница
        int right = n - 1; // Правая граница

        while (value <= n * n)
        {
            // Заполняем верхнюю границу слева направо
            for (int i = left; i <= right; i++)
            {
                array[top, i] = value;
                value++;
            }
            top++;

            // Заполняем правую границу сверху вниз
            for (int i = top; i <= bottom; i++)
            {
                array[i, right] = value;
                value++;
            }
            right--;

            // Заполняем нижнюю границу справа налево
            for (int i = right; i >= left; i--)
            {
                array[bottom, i] = value;
                value++;
            }
            bottom--;

            // Заполняем левую границу снизу вверх
            for (int i = bottom; i >= top; i--)
            {
                array[i, left] = value;
                value++;
            }
            left++;
        }

        // Выводим массив
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j].ToString("D2") + " ");
            }
            Console.WriteLine();
        }
    }
}

