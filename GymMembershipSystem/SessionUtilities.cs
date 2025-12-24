using System.Collections.Generic;
using System;
using System.Linq;

namespace GymMembershipSystem
{
    public class SessionUtilities
    {
        // Anonymous method using LINQ and Lambda Expression to filter sessions by a specific condition
        public void FindYogaSessionsByTrainer(string trainerName)
        {
            List<string> sessions = new List<string>
            {
                "1,Trainer1,Yoga,2024-12-01,10:00 AM",
                "2,Trainer2,Pilates,2024-12-02,11:00 AM",
                "3,Trainer1,Yoga,2024-12-03,09:00 AM"
            };

            // Anonymous method to filter the sessions for the given trainer and session type
            var yogaSessionsByTrainer = sessions.Where(delegate (string session)
            {
                string[] sessionDetails = session.Split(',');
                return sessionDetails[1].Trim() == trainerName && sessionDetails[2].Trim() == "Yoga";
            }).ToList();

            // Output the filtered sessions
            Console.WriteLine("Yoga sessions for trainer " + trainerName + ":");
            foreach (var session in yogaSessionsByTrainer)
            {
                Console.WriteLine(session);
            }
        }
    }
}
