namespace MauiHello
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

       private async void btn_hello_Clicked(object sender, EventArgs e)
        {
            lbl_Hello.Text = "Hello";

            await Task.WhenAny<bool>
              (
                 btn_Hello.RotateTo(360, 500),
                 lbl_Hello.ScaleTo(2, 2000),
                 lbl_Hello.TranslateTo(200, 500, 1000)
             );

            btn_Hello.Rotation = 0;
        }
    }
}
