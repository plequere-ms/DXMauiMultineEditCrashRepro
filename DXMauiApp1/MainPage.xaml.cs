namespace DXMauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage(CommentPageViewModel vm)
        {
            BindingContext = vm;

            InitializeComponent();
        }
    }
}