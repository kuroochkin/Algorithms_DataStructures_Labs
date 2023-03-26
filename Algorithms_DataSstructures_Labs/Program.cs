using Library.Searching;
using Library.Sorting;
using System.Diagnostics;

Random Random = new Random();

int[] ar = { 5, 3, 2, 1, 7, 9, 10, 4 };

Searching.SearchHash(ar, 7);


#region Array1
int N1 = 1900;
var Timer1 = new Stopwatch();

int[] array1 = new int[N1];

for (int i = 0; i < array1.Length; i++)
	array1[i] = Random.Next(0, 200);

Timer1.Start();
Sorting.QuickSort(array1);
Timer1.Stop();


//for (int i = 0; i < array1.Length; i++)
//	Console.WriteLine(array1[i]);

#endregion

#region Array2
int N2 = 2700;
var Timer2 = new Stopwatch();

int[] array2 = new int[N2];

for (int i = 0; i < array2.Length; i++)
	array2[i] = Random.Next(0, 200);

Timer2.Start();
Sorting.QuickSort(array2);
Timer2.Stop();

//for (int i = 0; i < array2.Length; i++)
//	Console.WriteLine(array2[i]);
#endregion

#region Array3
int N3 = 8000;
var Timer3 = new Stopwatch();

int[] array3 = new int[N3];

for (int i = 0; i < array3.Length; i++)
	array3[i] = Random.Next(0, 200);

Timer3.Start();
Sorting.QuickSort(array3);
Timer3.Stop();

//for (int i = 0; i < array3.Length; i++)
//	Console.WriteLine(array3[i]);

#endregion

Console.WriteLine($"Время сортировки 1 массива: {Timer1.Elapsed}");
Console.WriteLine($"Время сортировки 2 массива: {Timer2.Elapsed}");
Console.WriteLine($"Время сортировки 3 массива: {Timer3.Elapsed}");






