using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeadandoBD
{
    /// <summary>
    /// Számla osztály és adattagjai
    /// </summary>
    public class Szamlak
    {
        public int Id { get; set; } //Szamla Id
        public string Tulajdonos { get; set; } // Szamla tulajdonosának a neve
        public int Egyenleg { get; set; } // Számla egyenlege

        public Szamlak(int id, string tulajdonos, int egyenleg) //konstruktor
        {
            Id = id;
            Tulajdonos = tulajdonos;
            Egyenleg = egyenleg;
        }
    }
}
