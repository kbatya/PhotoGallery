using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using Microsoft.Maui.Controls;
namespace PhotoGallery;

public class MainPageDynamic : ContentPage
{
    private Button btnUp;
    private Button btnDown;
    private Image imgCnt;
    int count = 0;
    string img_source = "image_";
    public MainPageDynamic()
	{
		

        // Initialize controls
        btnUp = new Button
        {
            Text = "\u21E7", // Unicode character for the up arrow
            FontSize = 16,
            WidthRequest = 300,
            FontFamily = "NotoSansSymbols2-Regular.ttf"
        };
        btnUp.Clicked += OnBtnUpClicked;

        imgCnt = new Image
        {
            Aspect = Aspect.AspectFit,
            HeightRequest = 300,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            Source = "image_0.jpeg"
        };

        btnDown = new Button
        {
            Text = "\u21E9", // Unicode character for the down arrow
            FontSize = 16,
            WidthRequest = 300,
            FontFamily = "NotoSansSymbols2-Regular.ttf"
        };
        btnDown.Clicked += OnBtnDownClicked;

        // Create layout and add controls
        var stackLayout = new VerticalStackLayout
        {
            Padding = new Thickness(30, 0),
            Spacing = 25
        };
        stackLayout.Children.Add(btnUp);
        stackLayout.Children.Add(imgCnt);
        stackLayout.Children.Add(btnDown);

        // Add the layout to the ScrollView
        Content = new Microsoft.Maui.Controls.ScrollView
        {
            Content = stackLayout
        };
    }
    private void OnBtnUpClicked(object sender, EventArgs e)
    {
        count++;


        if (count == 8)
        {
            btnUp.IsEnabled = false;
            return;
        }
        btnUp.IsEnabled = true;
        btnDown.IsEnabled = true;
        update_image();

    }

    private void OnBtnDownClicked(object sender, EventArgs e)
    {
        count--;

        if (count == -1)
        {
            btnDown.IsEnabled = false;
            return;
        }
        btnDown.IsEnabled = true;
        btnUp.IsEnabled = true;
        update_image();
    }

    private void update_image()
    { imgCnt.Source = img_source + count.ToString() + ".jpeg"; }

}