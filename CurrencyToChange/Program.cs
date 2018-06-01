using System;

namespace CurrencyToChange
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			Console.WriteLine("Please enter the amount of money you would like to convert in the format - 00.00");

			var Currency = 0m;

			try
			{
				Currency = decimal.Parse(Console.ReadLine());
			}
			catch
			{
				Console.WriteLine("invalid enrty");
			}

			Console.WriteLine("Your currency = £" + Currency);

			int Pence = (int)(Currency * 100);

			//currency available is 1p 2p 5p 10p 20p 50p £1 £2 

			int remainder = Pence;

			while (remainder > 0)
			{
				if (remainder >= 200)
				{
					int TwoPounds = Pence / 200;
					remainder = Pence % 200;
					Console.WriteLine("Return " + TwoPounds + " £2 coins");
				}
				else if (remainder >= 100)
				{
					int OnePounds = remainder / 100;
					remainder = remainder % 100;
					Console.WriteLine("Return " + OnePounds + " £1 coins");
				}
				else if (remainder >= 50)
				{
					int FiftyPence = remainder / 50;
					remainder = remainder % 50;
					Console.WriteLine("Return " + FiftyPence + " 50p coins");
				}
				else if (remainder >= 20)
				{
					int TwentyPence = remainder / 20;
					remainder = remainder % 20;
					Console.WriteLine("Return " + TwentyPence + " 20p coins");
				}
				else if (remainder >= 10)
				{
					int TenPence = remainder / 10;
					remainder = remainder % 10;
					Console.WriteLine("Return " + TenPence + " 10p coins");
				}
				else if (remainder >= 5)
				{
					int FivePence = remainder / 5;
					remainder = remainder % 5;
					Console.WriteLine("Return " + FivePence + " 5p coins");
				}
				else if (remainder >= 2)
				{
					int TwoPence = remainder / 2;
					remainder = remainder % 2;
					Console.WriteLine("Return " + TwoPence + " 2p coins");
				}
				else if (remainder >=1 )
				{
					int OnePence = remainder / 1;
					remainder = remainder % 1;
					Console.WriteLine("Return " + OnePence + " 1p coins");
				}
			}

		}
	}
}

