using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_CookShares
{
    public class ResepBahan
    {
        #region FIELD
        Bahan bahan;
        Resep resep;
        float jumlah;
        #endregion

        #region CONSTRUCTOR
        public ResepBahan()
        {
            Bahan = new Bahan();
            Resep = new Resep();
            Jumlah = 0;
        }

        public ResepBahan(Bahan bahan, Resep resep, float jumlah)
        {
            Bahan = bahan;
            Resep = resep;
            Jumlah = jumlah;
        }
        #endregion

        #region PROPERTY
        public Bahan Bahan { get => bahan; set => bahan = value; }
        public Resep Resep { get => resep; set => resep = value; }
        public float Jumlah { get => jumlah; set => jumlah = value; }
        #endregion
    }
}
