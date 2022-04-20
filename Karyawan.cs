using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4462
{
    public class Karyawan
    {
        // constructor default
        public Karyawan()
        {

        }

        // constructor 3 parameter
        public Karyawan(string nik, string nama, int gajiperbulan)
        {
            NIK = nik;
            NAMA = nama;
            Gajiperbulan = gajiperbulan;
        }

        // properties
        public string NAMA { get; set; }
        public string NIK { get; set; }
        public int Gajiperbulan { get; set; }
    }
}
