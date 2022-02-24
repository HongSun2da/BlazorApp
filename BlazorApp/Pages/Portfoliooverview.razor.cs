using Microsoft.AspNetCore.Components;

namespace BlazorApp.Pages
{
    public partial class Portfoliooverview
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }


        protected override void OnInitialized()
        {
            
        }

        protected void GoToNaver()
        {
            NavigationManager.NavigateTo("https://www.naver.com");
        }
    }
}
