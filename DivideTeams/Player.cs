namespace DivideTeams
{
	public class Player
	{
		public string Name { get; set; }
		public int Rating { get; set; }

		public Player() { }

		public Player(string name, int rating)
		{
			Name = name;
			Rating = rating;
		}

		public override string ToString()
		{
			return $"{Name} - {Rating}";
		}
	}
}
