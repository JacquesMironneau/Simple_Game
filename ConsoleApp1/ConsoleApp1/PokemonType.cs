using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //co
    class PokemonType
    {
        const int MULTIPLIER = 2;
        const float REDUCER = 0.5f;

        public enum Tipe { Feu, Eau, Plante}
        public Tipe Nom { get; private  set; }

        public Tipe Faiblesses { get; private set; }

        public Tipe Resistances { get; private set; }

        public PokemonType(Tipe p_nom, Tipe p_faiblesses, Tipe p_resistances)
        {
            this.Nom = p_nom;
            this.Faiblesses = p_faiblesses;
            this.Resistances = p_resistances;
        }


    }
}
