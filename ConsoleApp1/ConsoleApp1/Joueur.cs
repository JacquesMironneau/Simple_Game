using System;

namespace ConsoleApp1
{

    //Handling fight ability of the player
    class Joueur
    {
        public Pokemon pokemonCourrant { get; set; }

        public Pokemon[] pokemons { get; set; }

        public Joueur()
        {
            this.pokemons = new Pokemon[6];
            this.pokemonCourrant = pokemons[0];

        }

        public void Attaquer(Attaque atk, Pokemon p)
        {
             //inflict damages
            p.Hp -= atk.Damage;        
        }

        public void switcher()
        {
            Console.WriteLine("switch");
        }

        public void UseItem(Pokemon p)
        {
            Console.WriteLine("using an item :^)");
        }

        public bool allPokemonsKO()
        {
            foreach (Pokemon p in pokemons)
                if (!p.KO) return false;
            
            return true;
        }
    }
}