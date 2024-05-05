using System.Runtime.InteropServices.ComTypes;

namespace RamazanKaratayOdev1;
public partial class RenkSecici : ContentPage
{
	public RenkSecici()
	{
		InitializeComponent();
	}


    private void Red_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        ColorUpdater();
    }

    private void Green_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        ColorUpdater();
    }

    private void Blue_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        ColorUpdater();
    }

    private void ColorUpdater() 
    { 
        BoxView.Color = Color.FromRgb((int)Red.Value, (int)Green.Value, (int)Blue.Value);
        string HexColor = BoxView.Color.ToHex();
        hex.Text = HexColor;


    }

    private void RandomColor(object sender, EventArgs e)
    {
        Random rnd = new Random();

        int[] colors_ = { 0, 0, 0 };

        for (int i = 0; i < 3; i++)
        {
            colors_[i] = (rnd.Next(0, 256));
        }

        Red.Value = colors_[0]; Green.Value = colors_[1]; Blue.Value = colors_[2];
        //BoxView.Color = Color.FromRgb(colors_[0], colors_[1], colors_[2]);
        ColorUpdater();
        
    }

    private void CopyClicked(object sender, EventArgs e)
    {
        Clipboard.SetTextAsync(hex.Text);
        DisplayAlert("Bilgi", "Renk kodu kopyalandý", "Tamam");
    }

}