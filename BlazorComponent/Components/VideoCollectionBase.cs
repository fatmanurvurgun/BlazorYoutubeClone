using BlazorComponent.Models;
using BlazorComponent.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComponent.Components
{
    public class VideoCollectionBase : ComponentBase
    {
        [Inject]
        private IVideoService VideoService { get; set; }
        public List<VideoDetail> Videos { get; set; }
        [Parameter]
        public EventCallback<VideoDetail> SelectVideo { get; set; } //üst component teki methoda callback yapıyoruz.

        protected override async Task OnInitializedAsync()
        {
            Videos = await VideoService.GetVideos();
        }


    }
}
