using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Events_VideoEncoding_3
{
    class VideoEncoder
    {
        // 1. define a delegate
        // 2. Define an event on the delegate
        // 3. Raise the event	

        // NEU: VideoEncodedArgs
        public delegate void VideoEncodedEventHandler(object source, VideoEventsArgs args);
        public event VideoEncodedEventHandler VideoEncoded;


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video");
            Thread.Sleep(1000);

            OnVideoEncoded(video);  // NEU Argument
        }

        // NEU Parameter Video
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                // NEU VideoEncodedArgs-Objekt + Parameter
                VideoEncoded(this, new VideoEventsArgs() { Video  = video });
            }
        }

    } // videoencoder

}

