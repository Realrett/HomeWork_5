// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
	// стоящих на нечётных позициях.
	// [3, 7, 23, 12] -> 19
	// [-4, -6, 89, 6] -> 0
	
	int[] InitArray()
	{
	    int[] res = new int[7];
	    Random rnd = new Random();
	    for (int i = 0; i < res.Length; i++)
	    {
	        res[i] = rnd.Next(10,100);
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
	
	void PrintP(int[] array)
	{
	    int sum = 0;
	    for (int i = 1; i < array.Length; i = i + 2)
	    {
	        sum = sum + array[i];
	    }
	    Console.WriteLine(sum);
	}
	
	int[] mass = InitArray();
	PrintArray(mass);
	PrintP(mass);
