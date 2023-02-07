using MauiVerter.MVVM.ViewModels;

namespace MauiVerter.MVVM.Views;

public partial class MenuView : ContentPage
{
	public MenuView()
	{
		InitializeComponent();
		BindingContext = new MenuViewModel();
	}

    void TapGestureRecognizer_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
		var element = (Grid)sender;
		var option = ((Label)element.Children
			.LastOrDefault()).Text;

		var converterView = new ConverterView()
		{
			BindingContext = new ConverterViewModel(option)
		};

		Navigation.PushAsync(converterView);
    }
}
