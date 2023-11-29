double[] array = new double[10];
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(100, 10000)/100.0; 
Console.WriteLine(string.Join(", ", array));
double r = 0;
double min = array[0];
double max = array[0];
    for (int i = 1; i < array.Length; i++)
     {
        if (min > array[i]) min = array[i];
        if (max < array[i]) max = array[i];
     }
Console.WriteLine("Минимальное значение " + min);
Console.WriteLine ("Максимальное значени " + max);
r = max - min;
Console.WriteLine("Разница между максимальным и минимальным значением = " + r);
