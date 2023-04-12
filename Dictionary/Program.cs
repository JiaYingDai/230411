using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var cities=new Dictionary<int, string>();
			cities.Add(1, "Taipei");
			cities.Add(55, "Tainan");
			cities.Add(333, "Taichung");

			bool result=cities.ContainsKey(1); // true
			result= cities.ContainsKey(44); // false

			string city = cities[333]; // Taichung

			foreach(var item in cities) // var: KeyValuePair<int,string>
			{
				Console.WriteLine(item.Key +" " + item.Value);
			}
		}
	}
}
