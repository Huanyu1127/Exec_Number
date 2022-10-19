using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{//找出數值區間內的所有質數
			int minValue = 2;
			int maxValue = 50;
			
			for ( int input=minValue ; input<=maxValue; input++)
			{
				for (int i = 2; i<= maxValue; i++) //2~50
				{
					if (i == input)
					{
						Console.WriteLine(input);
						break;
					}

					if (input % i == 0) 
					{
						break;
					}
				}
			}

			//for (int input = minValue; input <= maxValue; input++)
			//{
			//	int i;
			//	for (i = 2; i <= maxValue; i++) //3~50
			//	{

			//		if (input % i == 0)
			//		{
			//			break;
			//		}
			//	}

			//	if (i == input)
			//	{
			//		Console.WriteLine(input);

			//	}
			//}
		}
	}
}
