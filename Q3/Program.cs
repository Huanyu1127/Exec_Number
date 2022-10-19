using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{//有一個數值,是四位數
		 //	左邊二位的數字相同
		 //	右邊二位的數字相同
		 //這個四位數值, 剛好也是某整數的平方
		 //請問這個四位數值是什麼?
		 //從1100、1111開始
		 for(int i = 1100; i < 10000; i += 1100)
			{
				for(int k = 0; k < 100; k += 11)
				{
					int result = i + k;
					int resultSqrt=(int)(Math.Sqrt(result)); //已經無條件捨去了
					if (result== resultSqrt * resultSqrt)
					{
						Console.WriteLine(result);
					}
				}
			}
		}
	}
}
