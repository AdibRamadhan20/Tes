using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPraktikum6
{
	class Program
	{
		static void Main(string[] args)
		{
			Orang orang1 = new Orang("Adib Ramadhan", 19, "Jl.Swadaya No.180");
			orang1.TampilanInfo();

			Orang orang2 = new Orang("Adib Ramadhan", 24, "Jl.Ronggolawe No.21");
			orang2.UpdateInfo();

			Console.ReadKey();
		}
	}
}
