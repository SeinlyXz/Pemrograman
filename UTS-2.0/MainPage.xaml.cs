using UTS_2._0.Models;

namespace UTS_2._0;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
	private void OnCounterClicked1(object sender, EventArgs e)
	{
        Dosen dosen = new Dosen();
        dosen.setDosen(123456, "John Doe");
        dosen.setMatakuliah("Pemrograman Berorientasi Objek");
        //Console.WriteLine($"Nik: {dosen.Nik}, Nama: {dosen.Nama}, Matakuliah: {dosen.Matakuliah}");

		CounterBtn1.Text = $"Nik: { dosen.Nik}, Nama: { dosen.Nama}, Matakuliah: { dosen.Matakuliah}";

        SemanticScreenReader.Announce(CounterBtn1.Text);
    }
	//public static void Program()
	//{
	//	Dosen dosen = new Dosen(123456, "John Doe");
	//	dosen.SetDosen();
	//	dosen.SetMatakuliah();
	//	Console.WriteLine($"Nik: {dosen.Nik}, Nama: {dosen.Nama}, Matakuliah: {dosen.Matakuliah}");
	//}
}