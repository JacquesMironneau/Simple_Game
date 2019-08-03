using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public partial class Combat
    {
        //Display 0 atk 1 switch 2 item 3 fuire
        public String displayChoice()
        {
            String str = "";
            str += "Vous avez 3 choix possibles : \n";
            str += "Tapez 0 pour lancer une attaque \n";
            str += "Tapez 1 pour changer de pokemons \n";
            str += "Tapez 2 pour utiliser des items \n";
            str += "Tapez 3 pour fuire tel le lâche que vous êtes \n";
            return str;
        }

        public String displayAttaque()
        {
            String str = "";
            foreach (Attaque attaqueCourante in this.currentPlayer.pokemonCourrant.Moves)
            {
                str += attaqueCourante.Nom + " Type : " + attaqueCourante.Type + " Puissance : " + attaqueCourante.Damage + "\n";
            }
            return "";
        }

        //6 noms et hp de mes pkmns
        public String displayPokemons()
        {
            String str = "";
            foreach (Pokemon pokemonCourant in this.currentPlayer.pokemons )
            {
                str += pokemonCourant.Nom + " HP : " + pokemonCourant.Hp +  "\n";
            }
            return "";
        }

        //Display later
        public String displayObjects()
        {
            return "";
        }

        //nom et hp du mine et du mec en face
        public String displayCombat()
        {
            String str = "";
            
            foreach(Joueur player in this.Joueurs)
            {
                if (player == this.currentPlayer)
                    str += "Ton Pokemon : ";
                if (player != this.currentPlayer)
                    str += " Le pokemon du mec en face : ";
                str += player.pokemonCourrant.Nom + " Hp : " + player.pokemonCourrant.Hp + "\n"; 
            }
            return str;
        }

      
    }
}
