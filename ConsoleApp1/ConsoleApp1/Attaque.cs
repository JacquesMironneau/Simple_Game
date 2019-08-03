using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Attaque
    {
        public PokemonType Type { get; private set; }
        public int Effet { get; private set; }
        public int Precision { get; private set; }
        public int Damage { get; private set; }

    }
}