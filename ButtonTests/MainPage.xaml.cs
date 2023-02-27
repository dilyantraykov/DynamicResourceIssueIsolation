namespace ButtonTests;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
    }

    private void Start_OnClicked(object sender, EventArgs e)
	{
        StartBtn.IsEnabled = StartBtnDynamic.IsEnabled = false;
        StopBtn.IsEnabled = StopBtnDynamic.IsEnabled = true;
    }
}

