using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_VideoEncoding_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };

            var videoEncoder = new VideoEncoder();  // publisher
            var mailService = new MailService();    // subscriber

            var messageService = new MessageService();

            // publisher nimmt subscriber auf ...
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);

            Console.ReadLine();
        }
    }
}
