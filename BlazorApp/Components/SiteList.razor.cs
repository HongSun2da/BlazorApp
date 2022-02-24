using BlazorApp.Models;

namespace BlazorApp.Components
{
    public partial class SiteList
    {
        private List<Site> sites = new List<Site>();

        public List<Site> Sites
        {
            get { return sites; }
            set { sites = value; }
        }

        protected override void OnInitialized()
        {
            sites = new List<Site>() {
                new Site{ Id=1, Url="https://azure.microsoft.com", Name="Azure Site", Description="Microsoft Azure: 클라우드 컴퓨팅 서비스"},
                new Site{ Id=2, Url="https://blazor.net", Name="Blazor Site", Description="Blazor | Build client web apps with C# | .NET - Microsoft"},
                new Site{ Id=3, Url="https://docs.microsoft.com", Name="C# Site", Description="C# 문서 - 시작, 자습서, 참조."},
                new Site{ Id=4, Url="https://dotnet.microsoft.com", Name="Dotnet Site", Description="NET | Free. Cross-platform. Open Source"}
            };
        }
    }
}
