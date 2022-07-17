using PlayersService.Models;

namespace PlayersService.Respositry
{
    public interface IPlayerRepos
    {
        public String DeletePlayers(int id);
        public Players AddPlayer(Players player);
    }
}
