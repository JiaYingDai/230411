using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 每個字各出現幾次
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string s = "A,B,C,A,D,C,E";
			string[] items= s.Split(',');

			var maps=new Dictionary<string, int>();

			foreach (var item in items)
			{
				if (maps.ContainsKey(item))
				{
					maps[item]+=1;
				}
				else
				{
					maps.Add(item, 1);

				}
			}

			foreach (var item in maps)
			{
				Console.WriteLine($"key={item.Key}, 出現次數={item.Value}");
			}

		}
	}
}
