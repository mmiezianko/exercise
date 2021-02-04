using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace new1
{
    class Sklep
    {
        string _nazwa;
        private List<Plyta> Plyty = new List<Plyta>();
        
        string _telefon;
        public string NrTelefonu
        {
            get => _telefon;
            set
            {
                Regex wzorzec = new Regex(@"^\d{9}$|^\s{9}$");
                if (wzorzec.IsMatch(value))
                {
                    _telefon = value;
                }
                else throw new FormatException();
            }
        }

        public string Nazwa { get => _nazwa; set => _nazwa = value; }
        public List<Plyta> Plyta { get => Plyty; set => Plyty = value; }


        public Sklep()
        {
            this._nazwa = "";
            this._telefon = null;
            
        }

        public Sklep(string nazwa, string telefon)
        {
            _nazwa = nazwa;
            _telefon = telefon;
        }
        public void DodajPlyte(Plyta plyta)
        {
            Plyty.Add(plyta);
        }

        public void UsunPlyte(string tytul)

        {
            Plyta plyta = new Plyta();
            foreach(Plyta p in Plyty)
            {
                if(tytul == p.Tytul)
                {
                    plyta = p;
                }
            }
            Plyty.Remove(plyta);

        }

        public List<Plyta> Szukaj(string tytul)
        {
            return Plyty.FindAll(p => p.Tytul.ToLower() == tytul.ToLower());

        }

       public double SredniaCena()
        {
            double suma = 0;
            double ilosc = Plyty.Count;
            Plyta plyta = new Plyta();
            foreach (Plyta p in Plyty)
            {
                suma += p.Cena;
            }
            return Math.Round(suma / ilosc);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder("nazwa: " + this.Nazwa + " Telefon: " + this.NrTelefonu + "\n");
            stringBuilder.AppendLine("ilosc plyt: " + Plyty.Count + "\n");
            stringBuilder.AppendLine("Plyty: ");
            foreach (Plyta plytaZespolu in Plyty)
                stringBuilder.AppendLine(plytaZespolu.ToString());
            return stringBuilder.ToString();
        }

    }
}
