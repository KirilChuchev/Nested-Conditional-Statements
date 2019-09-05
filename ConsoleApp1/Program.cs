using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Math.Truncate(60.0/60));
			Console.WriteLine($"{Math.Truncate(60.0 / 60)} {0.0 % 60:D3}");
		}
	}
}
