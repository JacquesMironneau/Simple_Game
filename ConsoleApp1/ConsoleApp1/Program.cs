using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.PokemonType;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            PokemonType feu = new PokemonType(Tipe.Feu,  Tipe.Eau, Tipe.Plante );

            PokemonType plante = new PokemonType(Tipe.Plante, Tipe.Feu, Tipe.Eau);

            Attaque a = new Attaque("Feu 120 0", Tipe.Feu, 120, 0);
            Attaque b = new Attaque("Feu 12 100", Tipe.Feu, 12, 100);
            Attaque c = new Attaque("eau ", Tipe.Eau, 120, 100);

            Attaque d = new Attaque("plante", Tipe.Plante, 120, 30);

            Pokemon p = new Pokemon("Pikachu", 10000, 10, 10, 10, 10, a, b, c, d);

            Pokemon p2 = new Pokemon("PikachuV2", 10, 10, 10, 10, 10, a, b, c, d);


            Pokemon[] p8 = new Pokemon[2];
            p8[0] = p;
            p8[1] = p2;

            Joueur Kevin = new Joueur();
            Kevin.pokemons = p8;

            Joueur Bouffon = new Joueur();
            Bouffon.pokemons = p8;
            new Combat(Kevin, Bouffon);
        }
    }
}
