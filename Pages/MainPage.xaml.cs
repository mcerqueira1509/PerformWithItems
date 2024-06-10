namespace PerformWithItems.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button1_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Page1));
        }

        private async void Button2_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Page2));
        }

        private async void Button3_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Page3));
        }
    }

}
