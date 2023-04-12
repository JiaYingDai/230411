using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
	internal class Program
	{
		static void Main(string[] args)
		{
			HashSet<int> list = new HashSet<int>();
			list.Add(1);
			list.Add(2);
			list.Add(3);

			Console.WriteLine(list.Count);
			// Console.WriteLine(list.Contains(2));


		}
	}
}
