using BlazorApp.Models.pragimtech;
using Microsoft.AspNetCore.Components;

namespace BlazorApp.Pages
{
    public partial class DisplayEmployee
    {
        [Parameter]
        public Employee Employee { get; set; }
        [Parameter]
        public bool ShowFooter { get; set; }
        protected bool IsSelected { get; set; }
        [Parameter]
        public EventCallback<bool> OnEmployeeSelection { get; set; }
        protected async Task CheckBoxChanged(ChangeEventArgs e)
        {
            IsSelected = (bool)e.Value;
            await OnEmployeeSelection.InvokeAsync(IsSelected);
        }
    }
}
