using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanAsosiasi
{
    public class Kartu
    {
        public bool IsValid(Karyawan karyawan)
        {
            return karyawan.Status == true;
        }
    }
}