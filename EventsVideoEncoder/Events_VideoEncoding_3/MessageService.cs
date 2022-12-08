using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_VideoEncoding_3
{
    class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventsArgs e)
        {
            Console.WriteLine("Mailservice: Sending an email ... {0}", e.Video.Title);
        }
    }
}
