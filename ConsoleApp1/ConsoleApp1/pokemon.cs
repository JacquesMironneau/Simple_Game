using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    //random comment
    class pokemon
    {
        public string Nom { get; private set; }
        public int Hp { get;  set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Speed { get; set; }
        public int Level { get; set; }

        public bool KO { get { return Hp > 0; } }

        public Attaque[] Moves { get; private set; }

        public pokemon(string p_nom)
        {
            this.Nom = p_nom;
            this.Hp = 25;
            this.Atk = 10;
            this.Def = 5;
            this.Speed = 15;
            this.Level = 5;
            this.Moves = new Attaque[4];
            /* Créer des attaques et remplir
            moves[0] = p_move1;
            moves[1] = p_move2;
            moves[2] = p_move3;
            moves[3] = p_move4;*/

        }


        public pokemon(string p_nom, int p_hp, int p_atk, int p_def, int p_speed, int p_level, Attaque p_move1, Attaque p_move2, Attaque p_move3, Attaque p_move4)
        {
            this.Nom = p_nom;
            this.Hp = p_hp;
            this.Atk = p_atk;
            this.Def = p_def;
            this.Speed = p_speed;
            this.Level = p_level;
            this.Moves = new Attaque[4];
            this.Moves[0] = p_move1;
            this.Moves[1] = p_move2;
            this.Moves[2] = p_move3;
            this.Moves[3] = p_move4;

        }

        public void gainXp()
        {
            this.Level++;
        }
    }
}
