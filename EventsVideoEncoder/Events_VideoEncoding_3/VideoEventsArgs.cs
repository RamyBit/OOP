using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_VideoEncoding_3
{
    class VideoEventsArgs: EventArgs
    {
        public Video Video { get; set; }
    }
}
