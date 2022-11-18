// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
	// Напишите программу, которая покажет количество чётных чисел в массиве.
	// [345, 897, 568, 234] -> 2
	
	int[] InitArray()
	{
	    int[] res = new int[10];
	    Random rnd = new Random();
	    for (int i = 0; i < res.Length; i++)
	    {
	        res[i] = rnd.Next(100,1000);
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
	    for (int i = 0; i < array.Length; i++)
	    {
	        if(array[i] % 2 == 0) sum++;
	    }
	    Console.WriteLine($"В данном массиве {sum} четных чисел");
	}
	
	int[] mass = InitArray();
	PrintArray(mass);
	PrintP(mass);

