using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComponent.Components
{
    public class CommentBase :ComponentBase
    {
        [Parameter]
        public List<string> VideoComments { get; set; }

        public string commentText = string.Empty;
        public void InsertComment()
        {
            VideoComments.Add(commentText);
            commentText = string.Empty;
        }

    }
}
