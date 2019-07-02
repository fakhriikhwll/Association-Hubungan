using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanAsosiasi
{
    public class Karyawan
    {
        public string Nama { get; set; }
        public bool Status { get; set; }

        public bool Login(Kartu kartu)
        {
            //Hubungan Association
            return kartu.IsValid(this);
        }
    }

}