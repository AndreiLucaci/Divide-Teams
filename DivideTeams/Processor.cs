using System;
using System.Collections.Generic;
using System.Linq;

namespace DivideTeams
{
	public class Processor
	{
		public static
			Tuple<IEnumerable<Player>, IEnumerable<Player>>
			Process(IEnumerable<Player> players)
		{
			players = players.OrderBy(i => i.Rating);
			var firstTeam = players.Where((i, v) => v % 2 == 1).Select(i => i);
			var secondTeam = players.Where((i, v) => v % 2 == 0).Select(i => i);
			return new Tuple<IEnumerable<Player>, IEnumerable<Player>>(firstTeam, secondTeam);
		}
	}
}
