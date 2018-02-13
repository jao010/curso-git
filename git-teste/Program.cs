using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_teste
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Ola mundo!");
			Console.WriteLine("Como você está?");
			Console.WriteLine("gitHub seu lindo S2!");
			for (int i = 0; i < 100; i++)
			{
				if (i % 2 == 0)
					Console.WriteLine("GitHub");
				else
					Console.WriteLine("PornHub");
			}

			Console.ReadKey();

		}
	}
}
