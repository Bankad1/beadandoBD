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
    class Szamlak
    {
        public int Id { get; set; }
        public string Tulajdonos { get; set; }
        public int Egyenleg { get; set; }

        public Szamlak(int id, string tulajdonos, int egyenleg)
        {
            Id = id;
            Tulajdonos = tulajdonos;
            Egyenleg = egyenleg;
        }
    }
}
