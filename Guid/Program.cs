using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guid
{
	internal class Program
	{
		// GUID: 全域唯一識別碼，是一種由演算法生成的唯一標識
		static void Main(string[] args)
		{
			string value = Guid.NewGuid().ToString("N"); // N: 去掉dash
			Console.WriteLine(value);

			int seed=Guid

		}
	}
}
