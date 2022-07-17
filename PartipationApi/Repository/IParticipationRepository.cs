using ParticipationApi.Models;
using System.Collections.Generic;

namespace Participation.Repository
{
    public interface IParticipationRepository
    {
        public Participations GetStatusParticipantsrepos(string Status);
        public Participations GetAddParticipantsrepos(Participations participation);
        public string PutStatusUpadaterepos(int participationsid,string status);
    }
}
