using BlazorComponent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComponent.Services
{
    public class VideoService : IVideoService
    {
        private List<VideoDetail> _videos;
        public VideoService()
        {
            _videos = new List<VideoDetail>
            {
                 new VideoDetail
                {
                    Id=1,
                    Url = "https://www.youtube.com/watch?v=NUYvbT6vTPs",
                    Title = "Cat Vibing To Ievan Polkka (Official Video HD) Cat Vibing To Music | Cat Vibing Meme",
                    PublishedDate = new DateTime(2020,2,1),
                    Comments= new List<string>{"As bayrakları as as..."}
                },
                 new VideoDetail
                {
                    Id=2,
                    Url = "https://www.youtube.com/embed/watch?v=bViZs0x2nyA",
                    Title = "Neovaii - Labels",
                    PublishedDate = DateTime.UtcNow
                },
                 new VideoDetail
                {
                    Id=3,
                    Url = "https://www.youtube.com/embed/watch?v=DArzZ3RvejU",
                    Title = "Alessia Cara - Here (Lucian Remix)",
                    PublishedDate = new DateTime(2020, 2, 11)
                },
                 new VideoDetail
                {
                    Id=4,
                    Url = "https://www.youtube.com/embed/watch?v=gXNdCWXO8AM",
                    Title = "Masked Wolf - Astronaut In The Oceany",
                    PublishedDate = new DateTime(2020, 3, 23)
                },
            };
        }
        public async Task<VideoDetail> GetVideoById(int videoId)
        {
            return  _videos.Where(x => x.Id == videoId).FirstOrDefault();
            
        }
       public async Task<List<VideoDetail>> GetVideos()
        {
            return _videos;
        }
    }
}
