namespace Library.Sorting;

public class Sorting
{
	private static void Swap(int[] array, int i, int j)
	{
		if (i == j)
			return;

		int temp = array[i];
		array[i] = array[j];
		array[j] = temp;
	}

	public static void PrintArray(int[] array)
	{
		for(int i = 0; i <= array.Length; i++)
			Console.WriteLine(array[i]);
	}
	// Разделяй и властвуй
	// Разделение базируется на выборе опорных элементов
	// Опорный элемент находит свое место в конце каждого прохода
	// In-place алгоритм
	// Линейно-логарифмическая сложность 
	// Но может быть и N^2 (в редком случае)
	// Нестабильный
	public static void QuickSort(int[] array)
	{
		Sort(0, array.Length - 1);

		void Sort(int low, int high)
		{
			if (low >= high)
				return;
			int j = Partition(low, high);
			Sort(low, j - 1);
			Sort(j + 1, high);
		}

		int Partition(int low, int high)
		{
			int i = low;
			int j = high + 1;

			int pivot = array[low]; // опорный элемент

			while (true)
			{
				while (array[++i] < pivot)
				{
					if (i == high)
						break;
				}

				while (pivot < array[--j])
				{
					if (j == low)
						break;
				}

				if (i >= j)
					break;

				Swap(array, i, j);
			}

			Swap(array, low, j);
			return j;
		}
	}
}
