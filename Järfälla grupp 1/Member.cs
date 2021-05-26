using System;
using System.Collections.Generic;
using System.Text;

namespace Bad_example
{
    class Member
    {
        public Member(string username, string password, string email)
        {
            UserName = username;
            Password = password;
            Email = email;
            membership = new GoldMembership(this);
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        IMembership membership;

        public int VideosAvailible()
        {
            return membership.VideosAvailible();
        }

        public void UpgradeMembership()
        {
            if (membership is GoldMembership)
            {
                membership = new PlatinumMembership(this);
            }
            else if (membership is PlatinumMembership)
            {
                membership = new VIPMembership(this);
            }
        }
    }
}
