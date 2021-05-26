using System;
using System.Collections.Generic;
using System.Text;

namespace Bad_example
{
    class PlatinumMember
    {
        public PlatinumMember(string username, string password, string email)
        {
            UserName = username;
            Password = password;
            Email = email;
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }


        public int VideosAvailible()
        {
            return 20;
        }
    }
}
