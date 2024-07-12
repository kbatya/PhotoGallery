namespace PhotoGallery
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string img_source = "image_";

        public MainPage()
        {
            InitializeComponent();
            update_image();
        }

        private void OnBtnUpClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 8)
                count = 0;
            update_image();

        }

        private void OnBtnDownClicked(object sender, EventArgs e)
        {
            count--;

            if (count == -1)
                count = 7;
            update_image();
        }

        private void update_image()
        { imgCnt.Source = img_source + count.ToString() + ".jpeg"; }
    }

}
