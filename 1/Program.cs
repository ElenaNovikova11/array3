int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(1, 100); 
Console.WriteLine(string.Join(", ", array));
int A = 20; 
int B = 90;
int count = 0;
for (int i = 0; i < array.Length; i++)
if ((array[i] >= A) && (array[i] <= B))
count++;
Console.WriteLine("Количество элементов в диапазоне от 20 до 90 = " + count);

