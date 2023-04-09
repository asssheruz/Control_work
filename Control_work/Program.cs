﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый 
// массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → [ ]

string[] array1 = new string[8] {"Hello", "Russia", "356", "computer science", "world", "-)", "1234", "-2"};

PrintArray(array1);

void PrintArray(string[] array)
{
	Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
		if (i < array.Length - 1) Console.Write($"{array[i], 5}, ");
		else Console.Write($"{array[i]}");
	}
	Console.Write("]");
}

