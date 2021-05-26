using System;
using System.Collections.Generic;
using System.Text;

namespace Bad_example
{
    class PlatinumMembership : IMembership
    {
        Member context;

        public PlatinumMembership(Member context)
        {
            this.context = context;
        }

        public int VideosAvailible()
        {
            return 20;
        }
    }
}
