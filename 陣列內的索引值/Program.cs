using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 陣列內的索引值
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string setting = "XXXXXX@gmail.com;172.22.32.140;80;XXXXXX;myXXXXXX";
			string[] settingArray=setting.Split(';');

			int index = 0;
			string email = settingArray[index++];
			string ip = settingArray[index++];
			string id = settingArray[index++];
			string name = settingArray[index++];
			string password = settingArray[index++];

			// Console.WriteLine("Email: {0}\r\nIP: {1}\r\nID: {2}\r\nName: {3}\r\nPassword: {4}", email, ip, id, name, password);

			List<string> setting1 = new List<string>("");

		}
	}
}
