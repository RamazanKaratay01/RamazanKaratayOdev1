namespace RamazanKaratayOdev1;

public partial class KrediHesaplama : ContentPage
{
    private double tutar;
    private double faizOrani;
    private int vade;
    double brutFaiz;
    double taksit;
    double toplamFaiz;
    double toplam;
    public KrediHesaplama()
	{
		InitializeComponent();
	}
    private void KrediHesapla(object sender, EventArgs e)
    {
        if (double.TryParse(KrediTutariTxt.Text, out tutar) &&
                double.TryParse(FaizOraniTxt.Text, out faizOrani) &&
                int.TryParse(VadeTxt.Text, out vade))
        {


            switch (pickerKrediTipi.SelectedIndex)
            {

                case 0:
                    //Ýhtiyç kredisi
                    brutFaiz = ((faizOrani + (faizOrani * 0.10) + (faizOrani * 0.15)) / 100);
                    taksit = ((Math.Pow(1 + brutFaiz, vade) * brutFaiz) / (Math.Pow(1 + brutFaiz, vade) - 1)) * tutar;
                    toplam = taksit * vade;
                    toplamFaiz = toplam - tutar;
                    break;
                case 1:
                    // konut kredi
                    brutFaiz = ((faizOrani + (faizOrani * 0) + (faizOrani * 0)) / 100);
                    taksit = ((Math.Pow(1 + brutFaiz, vade) * brutFaiz) / (Math.Pow(1 + brutFaiz, vade) - 1)) * tutar;
                    toplam = taksit * vade;
                    toplamFaiz = toplam - tutar;
                    break;
                case 2:
                    // Taþýt kredisi
                    brutFaiz = ((faizOrani + (faizOrani * 0.15) + (faizOrani * 0.05)) / 100);
                    taksit = ((Math.Pow(1 + brutFaiz, vade) * brutFaiz) / (Math.Pow(1 + brutFaiz, vade) - 1)) * tutar;
                    toplam = taksit * vade;
                    toplamFaiz = toplam - tutar;
                    break;
                case 3:
                    // Ticari kredi
                    brutFaiz = ((faizOrani + (faizOrani * 0) + (faizOrani * 0.05)) / 100);
                    taksit = ((Math.Pow(1 + brutFaiz, vade) * brutFaiz) / (Math.Pow(1 + brutFaiz, vade) - 1)) * tutar;
                    toplam = taksit * vade;
                    toplamFaiz = toplam - tutar;
                    break;
            }


            lblToplamFaiz.Text = $"Toplam Faiz: {toplamFaiz:F2} TL";
            lblAylikOdeme.Text = $"Taksit: {taksit:F2} TL";
            lblToplam.Text = $"Toplam: {toplam:F2}TL";

        }
        else
        {
            DisplayAlert("Hata", "Lütfen geçerli deðerler giriniz", "Tamam");
        }



    }
}