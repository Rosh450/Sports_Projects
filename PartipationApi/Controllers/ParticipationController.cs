using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Participation.Repository;
using ParticipationApi.Models;

namespace Participation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipationController : ControllerBase
    {
        private static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(ParticipationController));
        private readonly IParticipationRepository Partobj;

        public ParticipationController(IParticipationRepository obj)
        {
            Partobj = obj;
        }
        [HttpGet("{status}")]
        public ActionResult Get(string status)
        {
            _log4net.Info("Http Get request to fetch partipation details by status");
            if (status== null)
            {
                return BadRequest();
            }
            var obj = Partobj.GetStatusParticipantsrepos(status);
            if (obj == null)
            {
                return BadRequest();
            }
            return Ok(obj);
        }

        [HttpGet("getParticipations")]
        public ActionResult GetParticipantsList()
        {
            _log4net.Info("Http Get request to Get All Stocks List");
            return Ok(ParticipationRepository.Participationslist);

        }
        [HttpPut("updateStatus")]
        public ActionResult UpdateStatus(int id,string status)
        {
            _log4net.Info("Http Get request to fetch partipation details by status");
            if (status == null && id==null)
            {
                return BadRequest();
            }
            else if(status == null)
            {
                return BadRequest();
            }
            else if(id==null)
            {
                return BadRequest();
            }
            var obj = Partobj.PutStatusUpadaterepos(id,status);
            if (obj == null)
            {
                return BadRequest();
            }
            return Ok(obj);

        }
        [HttpGet("addparticipation")]
        public ActionResult AddParticipation([FromQuery] Participations participation)
        {
            _log4net.Info("Http Get request to fetch partipation details by status");
            if (participation == null)
            {
                return BadRequest();
            }
            var obj = Partobj.GetAddParticipantsrepos(participation);
            if (obj == null)
            {
                return BadRequest();
            }
            return Ok(obj);


        }
    }
}
