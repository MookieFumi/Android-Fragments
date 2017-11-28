namespace AndroidFragment.Model
{
    public class Player
    {
        public Player(int id, string name, string team, string country, int number, string imageUrl = "https://usatftw.files.wordpress.com/2016/05/logo-golden-state-warriors1.png")
        {
            Id = id;
            Name = name;
            Team = team;
            Country = country;
            Number = number;
            ImageUrl = imageUrl;
        }

        public int Id { get; }
        public string Name { get; }
        public string Team { get; }
        public string Country { get; }
        public int Number { get; }
        public string ImageUrl { get; }
    }
}