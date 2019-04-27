using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp
{
    class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                //Access Youtube web service
                //Read the data
                //Create a list of Video objects
                throw new Exception("Opps some low level Youtube error.");
            }
            catch (Exception ex)
            {
                // Log
                throw new YouTubeException("Could not fetch the videos from Youtube", ex);
            }

            return new List<Video>();
        }
    }
}
