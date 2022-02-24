using BlazorApp.Models;

namespace BlazorApp.Components
{
    public partial class TechList
    {
        private List<Tech> teches = new List<Tech>();

        public List<Tech> Teches
        {
            get { return teches; }
            set { teches = value; }
        }

        protected override void OnInitialized()
        {
            teches = new List<Tech>() {
                new Tech{ Id=1, Name="Azure", CreateDate=DateTime.Now},
                new Tech{ Id=2, Name="Blazor", CreateDate=DateTime.Now},
                new Tech{ Id=3, Name="C#", CreateDate=DateTime.Now},
                new Tech{ Id=4, Name="Dotnet", CreateDate=DateTime.Now}
            };
        }
    }
}
