using YummyBakery.Models;
using Microsoft.AspNetCore.Components;

namespace YummyBakery.App.Pages
{
    public partial class PieCard
    {
        [Parameter]
        public Pie? Pie { get; set; }
    }
}
