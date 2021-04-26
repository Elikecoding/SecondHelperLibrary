using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHelperLibrary.ModelClasses
{
    //A model to help me with processing videos 
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsProcessed { get; set; }

        public class VideoContext 
        {
            public ISet<Video> Videos { get; set; }
        }

    }
}
