﻿int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(1, 100); 
Console.WriteLine(string.Join(", ", array));
int count = 0;
for (int i = 0; i < array.Length; i++)
if (array[i] % 2 == 0)
count++;
Console.WriteLine("Количество элементов четных = " + count);