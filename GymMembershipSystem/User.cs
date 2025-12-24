using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMembershipSystem
{
    public class User
    {
        public string Id { get; set; } 
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string MembershipType { get; set; }

        public virtual void ChangeMembership(string newMembershipType)
        {
            this.MembershipType = newMembershipType;
        }
    }

}
