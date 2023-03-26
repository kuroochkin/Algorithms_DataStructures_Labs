using Library.ForProgramm;
using Library.Searching;
using Library.Sorting;
using System.Diagnostics;

Random Random = new Random();

ForProgramm.TestQuickSort(1000);
ForProgramm.TestQuickSort(1900);
ForProgramm.TestQuickSort(2700);
ForProgramm.TestQuickSort(8000);

Console.WriteLine();

ForProgramm.TestQuickSort(3800);
ForProgramm.TestQuickSort(5400);
ForProgramm.TestQuickSort(16000);

Console.WriteLine();

ForProgramm.TestSearchHash(1000, 10);
ForProgramm.TestSearchHash(1900, 10);
ForProgramm.TestSearchHash(2700, 10);
ForProgramm.TestSearchHash(8000, 10);










