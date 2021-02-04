using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace new1
{
    [Serializable]
    class Plyta
    {
        public enum Kategoria { rock, folklor, metal, jazz, soul }
        string _wykonawca;
        string _tytul;
        DateTime dataWydania;
        double _cena;
        Kategoria _kategoria;
        [NonSerialized] static int numer;
        public static int Numer { get => numer; set => numer = value; }



        public string Wykonawca { get => _wykonawca; set => _wykonawca = value; }
        public string Tytul { get => _tytul; set => _tytul = value; }
        public DateTime DataWydania { get => dataWydania; set => dataWydania = value; }
        public double Cena { get => _cena; set => _cena = value; }
        public Kategoria Kategoria1 { get => _kategoria; set => _kategoria = value; }

        public Plyta()
        {
            Numer = 0;
        }
        public Plyta(string wykonawca, string tytul, string dataWydania, double cena, Kategoria kategoria)
        {
            ++Numer;
            _wykonawca = wykonawca;
            _tytul = tytul;
            DateTime.TryParse(dataWydania, out this.dataWydania);
            _cena = cena;
            _kategoria = kategoria;

        }

 

        public override string ToString()
        {
            return $"{this.Wykonawca}, {Tytul} {Kategoria1} {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DataWydania.Month)} {dataWydania.Year.ToString()} {Cena:C}";
        }

    }
}

