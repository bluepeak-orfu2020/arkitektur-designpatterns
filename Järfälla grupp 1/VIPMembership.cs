using System;
using System.Collections.Generic;
using System.Text;

namespace Bad_example
{
    class VIPMembership : IMembership
    {
        Member context;

        public VIPMembership(Member context)
        {
            this.context = context;
        }

        public int VideosAvailible()
        {
            return 25;
        }
    }
}
