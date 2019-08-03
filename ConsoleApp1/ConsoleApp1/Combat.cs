using System;

namespace ConsoleApp1
{
    partial class Combat
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
            this.currentPlayer = this.Joueurs[0].pokemonCourrant.Speed  >= this.Joueurs[1].pokemonCourrant.Speed ? Joueurs[0] : Joueurs[1];

            while (!Joueurs[1].allPokemonsKO() || !Joueurs[0].allPokemonsKO())
            {

               displayCombat();

                displayChoice();
                int theChoice = Console.Read();


                switch (theChoice)
                {
                    case 0: //Attack
                        Attaque atk = null;
                        Pokemon otherPokemon = currentPlayer == Joueurs[0] ? Joueurs[1].pokemonCourrant : Joueurs[0].pokemonCourrant;
                        //Pick attack

                        displayAttack();

                        int choice = Console.Read();

                        if (choice < 4 && choice > 0)
                        {
                            atk = this.currentPlayer.pokemonCourrant.Moves[choice];
                            this.currentPlayer.Attaquer(atk, otherPokemon);
                            Console.WriteLine("attack sent");
                        }
                        displayCombat();
                        //use attack

                        break;
                    case 1: //Switch
                        throw new NotImplementedException();
                        break;

                    case 2: //object
                        displayObjects();
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
            }
          
            

        }
    }
}