using PerformWithItems.Models;
using System.Collections.ObjectModel;

namespace PerformWithItems.Pages;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
		RandomTextLabel.Text = Guid.NewGuid().ToString();
		BindableLayout.SetItemsSource(StackListView, TheItems);
	}

	public ObservableCollection<TheItem> TheItems { get; set; } = [];


	private void Button1_Clicked(object sender, EventArgs e)
	{
		var count = TheItems.Count;
		for (int i = 0; i < 100; i++)
		{
			TheItems.Add(new(count + i));
		}
	}

	private async void Button2_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(Page2));
	}
}