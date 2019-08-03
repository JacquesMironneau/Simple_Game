using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.PokemonType;

namespace ConsoleApp1
{
    //comment pls
    class Attaque
    {
        public string Nom { get; private set; }
        public Tipe Type { get ; private set; }
        public int Effet { get; private set; }
        public int Precision { get; private set; }
        public int Damage { get; private set; }

        public Attaque(string p_nom, Tipe p_type,int p_damage,int p_precision)
        {
            this.Nom = p_nom;
            this.Type = p_type;
            this.Damage = p_damage;
            this.Precision = p_precision;
        }

    }
}