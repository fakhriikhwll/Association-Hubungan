using System;

namespace LatihanAsosiasi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Membuat Objek Kartu
            Kartu kartu = new Kartu();

            //Membuat Objek Karyawan
            Karyawan karyawan = new Karyawan();
            karyawan.Nama = "Paijo";
            karyawan.Status = true;

            //Hubungan Association
            if (karyawan.Login(kartu))
            {
                Console.WriteLine("Data karyawan valid");
            }
            else
            {
                Console.WriteLine("Data karyawan tidak valid");
            }
            Console.ReadKey();
        }
    }
}