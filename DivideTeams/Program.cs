using System;
using System.Collections.Generic;
using System.Linq;

namespace DivideTeams
{
	class Program
	{
		static void Main(string[] args)
		{
			var players = new List<Player> {
				new Player("a", 5),
				new Player("b", 7),
				new Player("c", 7),
				new Player("d", 10),
				new Player("e", 9),
				new Player("f", 10),
				new Player("g", 6),
				new Player("h", 6),
				new Player("i", 7),
				new Player("j", 7),
				new Player("k", 8),
				new Player("l", 8),
				new Player("m", 7),
			};

			var items = Processor.Process(players);

			Console.WriteLine("Team 1");
			foreach (var i in items.Item1)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine("Average team rating: {0}", items.Item1.Sum(i => i.Rating) / items.Item1.Count());

			Console.WriteLine("Team 2");
			foreach (var i in items.Item2)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine("Average team rating: {0}", items.Item2.Sum(i => i.Rating) / items.Item2.Count());
		}
	}
}
