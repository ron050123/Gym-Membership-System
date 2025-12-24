using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMembershipSystem
{
    public interface ISessionManagement
    {
        void BookSession(string userId, string trainer, string sessionType, string date, string time);
        List<string> GetUserSessions(string userId);
    }

}
