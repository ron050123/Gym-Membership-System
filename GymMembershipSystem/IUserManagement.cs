using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMembershipSystem
{
    public interface IUserManagement
    {
        void AddUser(string name, string email, string password, string membershipType);
        bool UserExists(string email);
        void ChangeMembership(string userId, string newMembershipType);
        string GetMembershipType(string userId);
    }
}
