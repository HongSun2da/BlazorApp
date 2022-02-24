namespace BlazorApp.Pages
{
    public partial class About
    {
        private readonly string _title = "정보 내용";
        private string? _subtitle;

        protected override void OnInitialized()
        {
            _subtitle = DateTime.Now.ToString();
        }
    }
}
