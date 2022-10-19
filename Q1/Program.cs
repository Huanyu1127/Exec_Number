using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{//判斷某數值是不是質數
			Console.Write("請輸入一個數字：");
			string input = Console.ReadLine();
			bool inputIsNumber = int.TryParse(input, out int inputNumber);
			if (inputIsNumber == false)
			{
				Console.WriteLine("您不是輸入數字");
				return;
			}
			if (inputNumber == 2)
			{
				Console.WriteLine("這是質數");
				return;
			}
			//開根號的輸入值
			int inputNumberSqar = (int)Math.Ceiling((Math.Sqrt(inputNumber)));
			
			//建立迴圈 避免重複跑>找開根號的輸入值 
			for(int i = 2; i <= inputNumberSqar; i++)
			{
				if (inputNumber % i == 0)
				{
					Console.WriteLine("這不是質數");
					return;
				}
			}
			Console.WriteLine("這是質數");
		}
	}
}
