using Newtonsoft.Json;
using SecondHelperLibrary.ModelClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SecondHelperLibrary.ModelClasses.Video;

namespace SecondHelperLibrary.ServiceClasses
{
    class VideoService
    {
        //This class will read out Video titles
        public string ReadVideoTitle()
        {
            //Read my file in question
            var str = File.ReadAllText("Video.txt");

            //Convert my video
             var video = JsonConvert.DeserializeObject<Video>(str);
            if (video == null)
            {
                return "Error parsing the video";
            } 

            

            //Return the title
            return video.Title;
          
    }
        //Get my unprocessed videos
        public string GetUnprocessedVideoAsCsv()
        {
            var videoIds = new List<int>();
            var context = new VideoContext();

            if (context != null)
            {
                var videos =
                    (from video in context.Videos
                     where !video.IsProcessed
                     select video).ToList();

                foreach (var v in videos)
                {
                    videoIds.Add(v.Id);
                }

                return String.Join(",", videoIds);
            }
            //Return my converted videos
            return videoIds.ToString();
        }

    }
}
