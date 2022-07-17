using Newtonsoft.Json;
using PlayersService.Models;

namespace PlayersService.Respositry
{
    public class PlayerRepos: IPlayerRepos
    {
        public static List<Players> Playerslist = new List<Players>()
        {
            new Players {playerid=1,playername="Dhana",age=21,contactnumber=983536738,email="dhana@gmail.com",gender="female",sportsname="Cricket"}
        };

        public Players AddPlayer(Players player)
        {
            try
            {
                if (player != null)
                {
                    var jsonParticipations = JsonConvert.SerializeObject(player);
                }
            }
            catch (Exception ex)
            {
                
            }
            Playerslist.Add(player);
            return player;

        }

        public String DeletePlayers(int id)
        {

            try
            {
                if(id == null)
                {
                    Players player = Playerslist.FirstOrDefault(s => s.playerid == id);
                    int a = Playerslist.FindIndex(s => s.playerid == id);
                    Playerslist.RemoveAt(a);
                }

            }
            catch(Exception ex)
            {

            }
            return "Removed Successfully";

        }

    }
}
