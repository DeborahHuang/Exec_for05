using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_for05
{
	internal class Program
	{
		static void Main(string[] args)
		{
			for (int i = 1; i <= 5; i++)
			{
				if (i == 5)
				{
					string b = $"{i}";
					char bb = b[0];
					string count5 = new string(bb, i - 1);
					Console.WriteLine(count5);
				}
				else
				{
					string star = new string('+', 5 - i);
					string c = $"{i}";
					char cc = c[0];
					string number = new string(cc, i);
					Console.WriteLine(star + number);
				}
			}
		}
	}
}
