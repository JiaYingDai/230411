using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 創一個空的List，再加入number
			List<int> numbers = new List<int>();
			numbers.Add(1);
			numbers.Add(2);
			numbers.Add(3);

			Console.WriteLine(numbers.Count); // 輸出3
			Console.WriteLine(numbers[0]); // 輸出1

			// 創含有數值的List
			List<int> numbers1 = new List<int> (){1,2,3,4,5 };
			numbers1.Add(1);

			Console.WriteLine(numbers1.Last()); // List最後一個
		}
	}
}
