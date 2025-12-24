using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymMembershipSystem
{
    public class AdminUser : User
    {
        public override void ChangeMembership(string newMembershipType)
        {
            // Special admin logic to change membership, if any
            base.ChangeMembership(newMembershipType);
            // Add any specific admin membership changing logic here
        }
    }

}
