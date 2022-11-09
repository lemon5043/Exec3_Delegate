using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Delegate
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> source = new List<int> { 2, 5, 3, 8, 5, 1, 6, 4, 8 };

			List<int> answer =  MathTool.GetEvenItems(source, n1 => n1 % 2 == 0);
			foreach (var item in answer)
			{
				Console.WriteLine(item);
			}
		}
	}

	static class MathTool
	{
		public static List<int> GetEvenItems(List<int> input, Func<int, bool> func )
		{
			List<int> result = new List<int>();
			for (int i = 0; i < input.Count; i++)
			{
				if (func(input[i]))
				{
					result.Add(input[i]);
				}
			}

			return result;
		}
	}
}
