using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string setting = "XXXXXX@gmail.com;172.22.32.140;80;XXXXXX;myXXXXXX";
			string[] settingArray = setting.Split(';');

			foreach (string item in settingArray)
			{
				Console.WriteLine(item);
			}

		}
	}
}
