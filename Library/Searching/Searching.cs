namespace Library.Searching;

public static class Searching
{
	public static void SearchHash(int[] arr, int k)
	{
		int[] newArr = new int[arr.Length];

		// Запоминаем изначальный массив в newArr
		for(int i = 0; i < arr.Length; i++)
		{
			newArr[i] = arr[i];
		}

		int maxValue = arr.Max();

		//Находим число, на которое будем делить (закон хэширования)
		int divider = maxValue / 2;

		//Хешируем значения
		for (int i = 0; i < arr.Length; i++)
		{
			arr[i] = arr[i] % divider;
		}

		//Отсортировываем шифрованный массив
		Sorting.Sorting.QuickSort(arr);

		//Ключ - остаток, значение - массив подходящих чисел из исходного массива
		Dictionary<int, IEnumerable<int>> dictionary = new Dictionary<int, IEnumerable<int>>();

		//Формируем хэш-таблицу
		foreach (var remainder in arr.Distinct<int>())
		{
			var collect = newArr.Where(x => x % divider == remainder);
			dictionary.Add(remainder, collect);
		}

		// Находим из хэш-таблицы подходящую строку
		int hashForKey = k % divider;

		var index = arr.Where(x => x % divider == hashForKey);

		//Обращаемся к значению(к массиву) по ключу и ещем в нем запрашиваемое значение)
		foreach (int num in index.Distinct<int>())
		{
			IEnumerable<int> a;

			if(dictionary.TryGetValue(num, out a))
			{
				if(a.Any(x => x == k))
					Console.WriteLine($"Ключ k найден - {k}.");
				else
					Console.WriteLine("Ключ не найден.");
			}
		}
	}
}
