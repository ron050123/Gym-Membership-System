using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace GymMembershipSystem
{
    public class SessionManagement : ISessionManagement
    {
        private string sessionsFile = "sessions.txt";

        public void BookSession(string userId, string trainer, string sessionType, string date, string time)
        {
            string session = $"{userId},{trainer},{sessionType},{date},{time}";
            File.AppendAllText(sessionsFile, session + Environment.NewLine);
        }

        public List<string> GetUserSessions(string userId)
        {
            if (!File.Exists(sessionsFile)) return new List<string>();

            return File.ReadAllLines(sessionsFile)
                       .Where(line => line.Split(',')[0].Trim() == userId)
                       .ToList();
        }
    }
}
