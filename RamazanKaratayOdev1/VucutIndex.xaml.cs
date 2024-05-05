namespace RamazanKaratayOdev1;

public partial class VucutIndex : ContentPage
{
	public VucutIndex()
	{
		InitializeComponent();
	}

	private void Index(object sender, EventArgs e)
	{
		if (double.TryParse(boy.Text, out double boy_) && double.TryParse(kilo.Text, out double kilo_) )
		{
			double BoySonuc = boy_ / 100;
			double Kitle = kilo_ / (BoySonuc * BoySonuc);
			string str_ = "";

			if (Kitle < 18.50)
				str_ = "Zayýf";

			else if (Kitle < 24.9 && (Kitle > 18.5))
				str_ = "Normal kilolu";


            else if (Kitle < 30 && (Kitle > 25))
				str_ = "Fazla kilolu";

			else
				str_ = "Obez"; 
            

            SonucLabel.Text = $"Vucüt Kitle Ýndeksiniz: {Kitle:F2} (" + str_ + ")";
		}
	}

}