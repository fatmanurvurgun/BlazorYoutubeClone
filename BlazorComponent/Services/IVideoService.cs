using BlazorComponent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComponent.Services
{
    public interface IVideoService
    {
        public Task<List<VideoDetail>> GetVideos();

        public Task<VideoDetail> GetVideoById(int videoId);
         
    }
}
