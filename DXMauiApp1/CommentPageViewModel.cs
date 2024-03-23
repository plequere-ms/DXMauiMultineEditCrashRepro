using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace DXMauiApp1;

public partial class CommentPageViewModel : ObservableObject
{
    [ObservableProperty]
    private string comment = "Test";

    [RelayCommand]
    async Task PostComment()
    {
        await Shell.Current.DisplayAlert(Comment, "OK", "Cancel");
    }

}
