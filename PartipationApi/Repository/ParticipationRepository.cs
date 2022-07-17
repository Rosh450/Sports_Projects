using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using ParticipationApi.Models;
using PartipationApi.Models;

namespace Participation.Repository
{
    public class ParticipationRepository : IParticipationRepository
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(ParticipationRepository));
        public static List<Participations> Participationslist = new List<Participations>()
        {
            new Participations { ParticipationId = 101, PlayerName = "Dhana", PlayerId=105,EventId=5,EventName="TestMatch",SportsId=11,SportsName="Cricket",Status="Accepted"},
            new Participations { ParticipationId = 102, PlayerName = "Dhana1", PlayerId=104,EventId=5,EventName="T20",SportsId=11,SportsName="Cricket",Status="Declined"}

        };

        public Participations GetAddParticipantsrepos(Participations participations)
        { 
            try
            {
                _log4net.Info("In Participations Repository Add details  is being searched");
                if (participations != null)
                {
                    var jsonParticipations = JsonConvert.SerializeObject(participations);
                    _log4net.Info("StatusFound " + jsonParticipations);
                }
                else
                {
                    _log4net.Info("In ParticipationsRepository,doesn't is not found");
                }
            }
            catch (Exception ex)
            {
                _log4net.Error("In Participations Repository, Exception Found - " + ex.Message);
            }
            Participationslist.Add(participations);
            return participations;


        }

        public Participations GetStatusParticipantsrepos(string Status)
        {
            Participations ParticipationsData = null;
            try
            {
                _log4net.Info("In Participations Repository, ParticipationsProvider is calling the Method GetParticipationsByNameRepository and " + Status + " is being searched");
                ParticipationsData = Participationslist.FirstOrDefault(s => s.Status == Status);
                if (ParticipationsData != null)
                {
                    var jsonParticipations = JsonConvert.SerializeObject(ParticipationsData);
                    _log4net.Info("StatusFound " + jsonParticipations);
                }
                else
                {
                    _log4net.Info("In ParticipationsRepository, Participations " + Status + " is not found");
                }
            }
            catch (Exception ex)
            {
                _log4net.Error("In Participations Repository, Exception Found - " + ex.Message);
            }
            return ParticipationsData;
        }

        public string PutStatusUpadaterepos(int participationsid,string status)
        {
            Participations ParticipationsData = null;
            try
            {
                _log4net.Info("In Participations Repository, " + participationsid + " is being searched");
                ParticipationsData = Participationslist.FirstOrDefault(s => s.ParticipationId == participationsid);
                if (ParticipationsData != null)
                {
                    var jsonParticipations = JsonConvert.SerializeObject(ParticipationsData);
                    Participationslist.Where(s=>s.ParticipationId==participationsid).ToList().ForEach(s=>s.Status=status);
                    _log4net.Info("Found " + jsonParticipations);
                }
                else
                {
                    _log4net.Info("In ParticipationsRepository, Participations " + participationsid + " is not found");
                }
            }
            catch (Exception ex)
            {
                _log4net.Error("In Participations Repository, Exception Found - " + ex.Message);
            }
            return status+ "Update Successfully";

        }
    }
}
