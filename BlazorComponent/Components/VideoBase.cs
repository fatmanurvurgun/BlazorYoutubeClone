using BlazorComponent.Models;
using BlazorComponent.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComponent.Components
{
    public class VideoBase : ComponentBase
    {
        [Inject]
        public IVideoService VideoService{ get; set; }

        [Parameter]
        public VideoDetail  SelectedVideo{ get; set; }
    }
}
