using System;
namespace UTS_2._0.Models
{
    public class Dosen
    {
        public string Matakuliah { get; set; }
        public string Nama { get; set; }
        public int Nik { get; set; }

        public Dosen()
        {
        }

        public void setDosen(int nik, string nama)
        {
            Nik = nik;
            Nama = nama;
        }

        public void setMatakuliah(string matakuliah)
        {
            Matakuliah = matakuliah;
        }
    }
}

