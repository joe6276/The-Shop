using Microsoft.AspNetCore.Components;

namespace TheShop.Web.Component
{
    public  partial class ProfilePicture
    {

        [Parameter]
        public RenderFragment ChildContent { get; set; } = default!;
    }
}
