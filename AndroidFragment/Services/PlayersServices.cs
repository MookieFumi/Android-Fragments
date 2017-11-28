using System.Collections.Generic;
using AndroidFragment.Model;

namespace AndroidFragment.Services
{
    public class PlayersServices
    {
        public IEnumerable<Player> GetPlayers()
        {
            return new List<Player>
            {
                new Player(1,"Devin Booker", "Phoenix Suns", "United states", 1, "https://imagesvc.timeincapp.com/v3/mm/image?url=https%3A%2F%2Fcdn-s3.si.com%2Fs3fs-public%2F2016%2F09%2F09%2Fdevin_booker_top_100_.jpg&w=800&q=85"),
                new Player(2,"Aaron Gordon", "Orlando Magic", "United states", 10, "https://imagesvc.timeincapp.com/v3/mm/image?url=https%3A%2F%2Fcdn-s3.si.com%2Fs3fs-public%2F2016%2F09%2F09%2Faaron_gordon_top_100_.jpg&w=800&q=85"),
                new Player(3,"Manu Ginobili", "San Antonio Spurs", "Argentina", 20, "https://imagesvc.timeincapp.com/v3/mm/image?url=https%3A%2F%2Fcdn-s3.si.com%2Fs3fs-public%2F2016%2F09%2F09%2Fmanu_ginobili_top_100_.jpg&w=800&q=85"),
                new Player(4,"J.R. Smith", "Cleveland Cavaliers", "United states", 5, "https://imagesvc.timeincapp.com/v3/mm/image?url=https%3A%2F%2Fcdn-s3.si.com%2Fs3fs-public%2F2016%2F09%2F09%2Fj.r._smith_top_100_.jpg&w=800&q=85"),
                new Player(5,"Kenneth Faried", "Denver Nuggets", "United states", 35, "https://imagesvc.timeincapp.com/v3/mm/image?url=https%3A%2F%2Fcdn-s3.si.com%2Fs3fs-public%2F2016%2F09%2F09%2Fkenneth_faried_top_100_.jpg&w=800&q=85"),
                new Player(6,"Giannis Antetokounmpo", "Milwaukee Bucks", "Greece", 48, "https://imagesvc.timeincapp.com/v3/mm/image?url=https%3A%2F%2Fcdn-s3.si.com%2Fs3fs-public%2F2016%2F09%2F12%2Fgiannis_antetokounmpo_top_100_.jpg&w=800&q=85"),
                new Player(7,"Isaiah Thomas", "Boston Celtics", "United states", 4, "https://imagesvc.timeincapp.com/v3/mm/image?url=https%3A%2F%2Fcdn-s3.si.com%2Fs3fs-public%2F2016%2F09%2F12%2Fisaiah_thomas_top_100_.jpg&w=800&q=85"),
                new Player(8,"Serge Ibaka", "Orlando Magic", "Spain", 7, "https://imagesvc.timeincapp.com/v3/mm/image?url=https%3A%2F%2Fcdn-s3.si.com%2Fs3fs-public%2F2016%2F09%2F12%2Fserge_ibaka_top_100.jpg&w=800&q=85"),
                new Player(9,"Pau Gasol", "San Antonio Spurs", "Spain", 16, "https://imagesvc.timeincapp.com/v3/mm/image?url=https%3A%2F%2Fcdn-s3.si.com%2Fs3fs-public%2F2016%2F09%2F12%2Fpau_gasol_top_100_.jpg&w=800&q=85"),
                new Player(10,"James Harden", "Houston Rockets", "United states", 13, "https://imagesvc.timeincapp.com/v3/mm/image?url=https%3A%2F%2Fcdn-s3.si.com%2Fs3fs-public%2F2016%2F09%2F14%2Fjames-harden-rockets-nba-top-100.jpg&w=800&q=85"),
                new Player(11,"Stephen Curry", "Golden State Warriors", "United states", 30, "https://imagesvc.timeincapp.com/v3/mm/image?url=https%3A%2F%2Fcdn-s3.si.com%2Fs3fs-public%2F2016%2F09%2F15%2Fstephen-curry-warriors-nba-top-100.jpg&w=800&q=85"),
                new Player(12,"Goran Dragic", "Miami Heat", "Eslvania", 7, "https://imagesvc.timeincapp.com/v3/mm/image?url=https%3A%2F%2Fcdn-s3.si.com%2Fs3fs-public%2F2016%2F09%2F10%2Fgoran-dragic-heat-nba-top-100-players.jpg&w=800&q=85")
            };
        }
    }
}