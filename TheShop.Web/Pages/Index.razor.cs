using TheShop.Web.Component.Widgets;

namespace TheShop.Web.Pages
{
    public partial class Index
    {

        public List<Type> Widgets { get; set; }    = new List<Type>() { typeof(EmployeeCount), typeof(Messages) };
    }
}
