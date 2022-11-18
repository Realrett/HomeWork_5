// Задача 38: Задайте массив вещественных чисел.
	//  Найдите разницу между максимальным и минимальным элементов массива.
	// [3 7 22 2 78] -> 76
	
	int[] InitArray()
	{
	    int[] res = new int[10];
	    Random rnd = new Random();
	    for (int i = 0; i < res.Length; i++)
	    {
	        res[i] = rnd.Next(0,100);
	    }
	    return res;
	}
	
	void PrintArray(int[] array)
	{
	    for (int i = 0; i < array.Length; i++)
	    {
	        Console.Write($"{array[i]} ");
	    }
	    Console.WriteLine();
	}
	
	int GetMin(int[] array)
	{
	    int min = array[0];
	    for (int i = 1; i < array.Length; i++)
	    {
	        if (min > array[i]) min = array[i];
	    }
	    return min;
	}
	
	int GetMax(int[] array)
	{
	    int max = array[0];
	    for (int i = 1; i < array.Length; i++)
	    {
	        if (max < array[i]) max = array[i];
	    }
	    return max;
	}
	
	int[] mass = InitArray();
	PrintArray(mass);
	Console.WriteLine($"Максимальное значение {GetMax(mass)} - Минимальное хначение {GetMin(mass)} = {GetMax(mass) - GetMin(mass)}");
