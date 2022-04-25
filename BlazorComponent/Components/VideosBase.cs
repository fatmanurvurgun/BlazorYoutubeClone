using BlazorComponent.Models;
using BlazorComponent.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComponent.Components
{
    public class VideosBase : ComponentBase
    {
        [Inject]
        private IVideoService VideoService { get; set; }

        public VideoDetail secilenVideo { get; set; }

        protected override async Task OnInitializedAsync()
        {
            secilenVideo = await VideoService.GetVideoById(1);
        }
        public void SecilenVideoChanged(VideoDetail video)
        {
            secilenVideo = video;
        }
    }
}
