using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 買雞問題_三變數
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 共100元
			// 公雞1隻5元
			// 母雞1隻3元
			// 小雞3隻1元
			// Q: 公雞母雞小雞共買幾隻
			// 公雞: cock, 母雞: hen, 小雞: chiken
			// 0. 100萬圈，但很快
			// 1. 改變數名稱，小雞不必迴圈，1萬圈
			// 2. 公雞最多20隻，迴圈小於2000圈 (1590)
			// 3. 改magic number, 310圈

			int maxCock = 100 / 5;
			
			for (int cock=0; cock<maxCock; cock++)
			{
				int maxHen = (100 - 5 * cock) / 3;
				
				for (int hen=0; hen<maxHen; cock++)
				{
					int chicken = 100 - cock - hen;
					if (chicken % 3 != 0) continue;
					if (5 * cock + 3 * hen + chicken/3 == 100)
					{
						Console.WriteLine($"公雞{cock}，母雞{hen}，小雞{chicken}");
					}
				}
			}


		}
	}
}
