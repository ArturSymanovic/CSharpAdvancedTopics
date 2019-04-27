using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedCSharp
{
    class VideoEncoder
    {
        // 1 - Define a delegate
        // 2 - Define an event based on that delegate
        // 3 - Raise the event

        //Determines the signature of the method in the subscriber
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        public event VideoEncodedEventHandler VideoEncoded;

        // Using built in .Net EventHandlet to achieve the same thing
        // EventHandler
        // EventHandler<>
        public event EventHandler<VideoEventArgs> VideoEncoded1;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }
        
        // By Convention Event publisher method should be protected virtual void and method starts with On
        protected virtual void OnVideoEncoded(Video video)
        {
            //Checking if there are any subscribers
            if (VideoEncoded != null)
                //Calling the event
                VideoEncoded(this, new VideoEventArgs() { Video = video});
        }
    }

    class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}
