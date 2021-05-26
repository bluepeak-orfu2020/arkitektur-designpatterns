using System;
using System.Collections.Generic;
using System.Text;

namespace Bad_example
{
    class GoldMembership : IMembership
    {
        Member context;

        public GoldMembership(Member context)
        {
            this.context = context;
        }

        public int VideosAvailible()
        {
            return 15;
        }
    }
}
