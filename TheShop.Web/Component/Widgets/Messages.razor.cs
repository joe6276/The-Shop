namespace TheShop.Web.Component.Widgets
{
    public partial class Messages
    {
        public int MessageCount { get; set; }

        protected override Task OnInitializedAsync()
        {   
            MessageCount=new Random().Next(10);
            return base.OnInitializedAsync();
        }
    }
}
