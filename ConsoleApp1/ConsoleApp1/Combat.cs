using System;

namespace ConsoleApp1
{
    internal class Combat
    {
        public Joueur[] Joueurs {get; set;}

        private Joueur currentPlayer;

        public Combat(Joueur player, Joueur bot)
        {
            this.Joueurs = new Joueur[2];
            //Launch the fight
            this.Joueurs[0] = player;
            this.Joueurs[1] = bot;
            this.play();
        }

        private void play()
        {
            this.currentPlayer = this.Joueurs[0].pokemonCourrant.speed  >= this.Joueurs[1].pokemonCourrant.speed ? Joueurs[0] : Joueurs[1];

            while (true)
            {
                int theChoice = 3;

                switch (theChoice)
                {
                    case 0: //Attack
                        Attaque atk;
                        Pokemon otherPokemon = currentPlayer == Joueurs[0] ? Joueurs[1].pokemonCourrant : Joueurs[0].pokemonCourrant;
                        //Pick attack
                        int choice = Console.Read();
                        if (choice < 4 && choice > 0)
                            atk = this.currentPlayer.pokemonCourrant.Moves[choice];

                        //use attack
                        this.currentPlayer.attaquer(atk, otherPokemon);

                        break;
                    case 1: //Switch
                        throw new NotImplementedException();
                        break;

                    case 2: //object
                        throw new NotImplementedException();
                        break;

                    case 3: //flee
                        Console.WriteLine("You fled");
                        break;

                    default: // issue here
                        throw new NotImplementedException();
                }

                //swap
                this.currentPlayer = currentPlayer == this.Joueurs[0] ? this.Joueurs[1] : this.Joueurs[0];

                foreach (Joueur j in Joueurs)
                {

                }
                
            }
          
            

        }
    }
}