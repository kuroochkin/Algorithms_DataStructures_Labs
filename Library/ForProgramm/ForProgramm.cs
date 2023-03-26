using System.Diagnostics;
using Library.Sorting;


namespace Library.ForProgramm
{
	public static class ForProgramm
	{
		public static void TestQuickSort(int N)
		{
			var Timer = new Stopwatch();

			int[] array = new int[N];

			for (int i = 0; i < array.Length; i++)
				array[i] = new Random().Next(0, 200);

			Timer.Start();
			Sorting.Sorting.QuickSort(array);
			Timer.Stop();

			Console.WriteLine($"Время сортировки массива при {N} элементах: {Timer.Elapsed}");

			//for (int i = 0; i < array.Length; i++)
			//	Console.WriteLine(array[i]);
		}

		public static void TestSearchHash(int N, int k)
		{
			var Timer = new Stopwatch();

			int[] array = new int[N];

			for (int i = 0; i < array.Length; i++)
				array[i] = new Random().Next(0, 200);

			Timer.Start();
			Searching.Searching.SearchHash(array , k);
			Timer.Stop();

			Console.WriteLine($"Время поиска при {N} элементах: {Timer.Elapsed}");

			//for (int i = 0; i < array.Length; i++)
			//	Console.WriteLine(array[i]);
		}

	}


}
