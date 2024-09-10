namespace _4M02mob1
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            lblNapis.TextColor = Colors.Yellow;
        }

        private void onCzerwonyClicked(object sender, EventArgs e)
        {
            lblNapis.TextColor = Colors.Red;
        }
        private void onZielonyClicked(object sender, EventArgs e)
        {
            lblNapis.TextColor= Colors.Green;
        }
        private void onWlacz2Clicked(object sender, EventArgs e)
        {
            btnWlacz1.IsEnabled = false;
            btnWlacz2.IsEnabled = true;
        }
        private void onWlacz1Clicked(object sender, EventArgs e)
        {
            btnWlacz2.IsEnabled = false;
            btnWlacz1.IsEnabled = true;
        }
        private void onPokazClicked(object sender, EventArgs e)
        {
            imgRower.IsVisible = true;
        }
        private void onUkryjClicked(object sender, EventArgs e)
        {
            imgRower.IsVisible= false;
        }
        private void onPokazUkryj(object sender, EventArgs e)
        {
            imgRower.IsVisible = ! imgRower.IsVisible;
            //if(imgRower.IsVisible) 
             //zmiana napisu na prycisku   
        }

    }

}
