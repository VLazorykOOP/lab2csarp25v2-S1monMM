using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Оберіть завдання для виконання:");
        Console.WriteLine("1. Завдання 1 (Замінити елементи, що потрапляють в інтервал, на нулі)");
        Console.WriteLine("2. Завдання 2 (Замінити всі максимальні елементи на нулі)");
        Console.WriteLine("3. Завдання 3 (Поміняти місцями середні стовпці матриці)");
        Console.WriteLine("4. Завдання 4 (Останній парний елемент для кожного рядка східчастого масиву)");
        Console.Write("Ваш вибір: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Task1();
                break;
            case 2:
                Task2();
                break;
            case 3:
                Task3();
                break;
            case 4:
                Task4();
                break;
            default:
                Console.WriteLine("Невірний вибір.");
                break;
        }
    }

    // Завдання 1: Замінити елементи, що потрапляють в інтервал, на нулі (Один і два масиви)
    static void Task1()
    {
        Console.WriteLine("Оберіть тип масиву:");
        Console.WriteLine("1. Одновимірний");
        Console.WriteLine("2. Двовимірний");
        Console.Write("Ваш вибір: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                OneDimensionalArray();
                break;
            case 2:
                TwoDimensionalArray();
                break;
            default:
                Console.WriteLine("Невірний вибір.");
                break;
        }
    }

    // Метод для роботи з одновимірним масивом
    static void OneDimensionalArray()
    {
        Console.Write("Введіть розмір масиву: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[n];
        Random random = new Random();

        // Заповнення масиву випадковими числами
        Console.WriteLine("Початковий масив:");
        for (int i = 0; i < n; i++)
        {
            array[i] = random.Next(-50, 51); // Випадкові числа в діапазоні [-50, 50]
            Console.Write(array[i] + " ");
        }

        // Введення меж інтервалу
        Console.WriteLine("\nВведіть межі інтервалу:");
        Console.Write("Нижня межа: ");
        int lowerBound = Convert.ToInt32(Console.ReadLine());
        Console.Write("Верхня межа: ");
        int upperBound = Convert.ToInt32(Console.ReadLine());

        // Заміна елементів, що потрапляють в інтервал
        for (int i = 0; i < n; i++)
        {
            if (array[i] >= lowerBound && array[i] <= upperBound)
            {
                array[i] = 0;
            }
        }

        // Виведення зміненого масиву
        Console.WriteLine("Змінений масив:");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
    }

    // Метод для роботи з двовимірним масивом
    static void TwoDimensionalArray()
    {
        Console.Write("Введіть кількість рядків: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введіть кількість стовпців: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[rows, cols];
        Random random = new Random();

        // Заповнення масиву випадковими числами
        Console.WriteLine("Початковий масив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = random.Next(-50, 51); // Випадкові числа в діапазоні [-50, 50]
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Введення меж інтервалу
        Console.WriteLine("\nВведіть межі інтервалу:");
        Console.Write("Нижня межа: ");
        int lowerBound = Convert.ToInt32(Console.ReadLine());
        Console.Write("Верхня межа: ");
        int upperBound = Convert.ToInt32(Console.ReadLine());

        // Заміна елементів, що потрапляють в інтервал
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (array[i, j] >= lowerBound && array[i, j] <= upperBound)
                {
                    array[i, j] = 0;
                }
            }
        }

        // Виведення зміненого масиву
        Console.WriteLine("Змінений масив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Завдання 2: Замінити всі максимальні елементи на нулі
    static void Task2()
    {
        Console.Write("Введіть розмір масиву: ");
        int n = int.Parse(Console.ReadLine());

        // Ініціалізація масиву
        int[] arr = new int[n];

        // Введення елементів масиву
        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}]: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Знаходимо максимальний елемент у масиві
        int max = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        // Замінюємо всі максимальні елементи на нулі
        for (int i = 0; i < n; i++)
        {
            if (arr[i] == max)
            {
                arr[i] = 0;
            }
        }

        // Виведення оновленого масиву
        Console.WriteLine("Оновлений масив:");
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
    }

    // Завдання 3: Поміняти місцями середні стовпці матриці
    static void Task3()
    {
        // Введення розміру матриці
        Console.Write("Введіть кількість рядків: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введіть кількість стовпців: ");
        int cols = int.Parse(Console.ReadLine());

        // Ініціалізація двовимірного масиву
        int[,] matrix = new int[rows, cols];

        // Введення елементів матриці
        Console.WriteLine("Введіть елементи матриці:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"matrix[{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Визначення середніх стовпців
        int mid1, mid2;

        if (cols % 2 == 0) // Якщо кількість стовпців парна
        {
            mid1 = cols / 2 - 1;
            mid2 = cols / 2;
            // Міняємо місцями два середні стовпці
            for (int i = 0; i < rows; i++)
            {
                int temp = matrix[i, mid1];
                matrix[i, mid1] = matrix[i, mid2];
                matrix[i, mid2] = temp;
            }
        }
        else // Якщо кількість стовпців непарна
        {
            mid1 = cols / 2;
            // Міняємо перший і середній стовпець
            for (int i = 0; i < rows; i++)
            {
                int temp = matrix[i, 0];
                matrix[i, 0] = matrix[i, mid1];
                matrix[i, mid1] = temp;
            }
        }

        // Виведення оновленої матриці
        Console.WriteLine("Оновлена матриця:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // Завдання 4: Останній парний елемент для кожного рядка східчастого масиву
    static void Task4()
    {
        // Введення кількості рядків у масиві
        Console.Write("Введіть кількість рядків (n): ");
        int n = int.Parse(Console.ReadLine());

        // Створення масиву масивів
        int[][] jaggedArray = new int[n][];

        // Введення елементів для кожного рядка
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введіть кількість елементів у {i + 1}-му рядку: ");
            int m = int.Parse(Console.ReadLine());

            jaggedArray[i] = new int[m];

            Console.WriteLine($"Введіть {m} елементів для {i + 1}-го рядка:");
            for (int j = 0; j < m; j++)
            {
                jaggedArray[i][j] = int.Parse(Console.ReadLine());
            }
        }

        // Створення нового масиву для збереження останніх парних елементів
        int[] lastEvenElements = new int[n];

        // Проходимо по кожному рядку
        for (int i = 0; i < n; i++)
        {
            lastEvenElements[i] = -1; // Ініціалізуємо значенням -1, якщо не знайдемо парний елемент

            // Проходимо по кожному елементу рядка в зворотному порядку
            for (int j = jaggedArray[i].Length - 1; j >= 0; j--)
            {
                if (jaggedArray[i][j] % 2 == 0) // Якщо елемент парний
                {
                    lastEvenElements[i] = jaggedArray[i][j];
                    break; // Виходимо з циклу, бо знайшли останній парний елемент
                }
            }
        }

        // Виведення результату
        Console.WriteLine("Масив останніх парних елементів:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Рядок {i + 1}: {lastEvenElements[i]}");
        }
    }
}
