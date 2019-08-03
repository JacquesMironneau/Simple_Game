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

        public string Nom { get; private  set; }

        public PokemonType[] Faiblesses { get; private set; }

        public PokemonType[] Resistances { get; private set; }

        public PokemonType(string p_nom, PokemonType[] p_faiblesses, PokemonType[] p_resistances)
        {
            this.Nom = p_nom;
            this.Faiblesses = p_faiblesses;
            this.Resistances = p_resistances;
        }


    }
}
