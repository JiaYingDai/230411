using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 }; // 整數陣列

			for (int k = 0;  k < numbers.Length; k++)
			{
				Console.WriteLine(numbers[k]);
			}

			string[] items = new string[] { "A", "B", "C", "D" }; // 字串陣列


			string fruits= "Apple,Lemon,Watermelon,Banana,Peach";
			string[] fruitsItems=fruits.Split(','); // {"Apple", "Lemon", "Watermelon", "Banana", "Peach"}
			for (int i = 0; i < fruitsItems.Length; i++)
			{
				Console.WriteLine(fruitsItems[i]);
			}

			int[] numbers1 = new int[3]; // 創建一個3個位子的陣列，各位子的數值預設為整數0
			numbers1[0]=1;
			numbers1[1]=2;
			numbers1[2]=3;

			Console.WriteLine(numbers1);
		}
	}
}
