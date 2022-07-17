using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlayersService.Models;
using PlayersService.Respositry;

namespace PlayersService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayerRepos playerobj;

        public PlayersController(IPlayerRepos obj)
        {
            playerobj = obj;
        }

        // GET: api/Players
       [HttpGet("GetAllPlayer")]
        public ActionResult GetAllPlayers()
        {
            return Ok(PlayerRepos.Playerslist);
        }
        [HttpPost("AddPlayer")]
        public ActionResult AddPlayer([FromBody] Players player)
        {
            if (player== null)
            {
                return BadRequest();
            }
            var obj = playerobj.AddPlayer(player);
            if (obj == null)
            {
                return BadRequest();
            }
            return Ok(obj);
        }
        [HttpDelete]
        public ActionResult DeletePlayer(int id)
        {
            if(id==null)
            {
                return BadRequest();

            }
            var obj = playerobj.DeletePlayers(id);
            if(obj == null)
            {
                return BadRequest();
            }
            return Ok(obj);
        }
    }
}
