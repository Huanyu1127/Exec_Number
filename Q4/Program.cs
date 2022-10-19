using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{//百元買百雞
		//想用一百元買剛好一百隻雞, 公雞 5 元, 母雞 3 元, 小雞三隻 1 元
		//字彙表:
		//公雞(Cock), 母雞(Hen), 小雞(Chicken)
		//小雞z隻
		//5x+3y+z=100
		//x+y+3z=100
		//6x+4y+4z=200

		//3x+2y+2z=100
		//5x+3y+z=3x+2y+2z
		//2x+y=z
		//
		//4x+2y+3x+2y=100
		//7x+4y=100
		for(int i = 0; i <= 100; i++)
			{
				for(int k=0; k <= 100; k++)
				{
					for (int h = 0; h <= 100; h++)
					{
						if (5 * i + 3 * k + h == 100 && i + k + 3*h == 100)
						{
							Console.WriteLine($"公雞是{i} 母雞是{k} 小雞是{h}");
						}
					}


				}
			}
		}
	}
}
