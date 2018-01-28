using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPart1
{
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();
            hero.Name = "hero";
            hero.Health = 100;
            hero.DamageMaximum = 5;
            hero.AttackBonus = 10;

            Character monster = new Character();
            monster.Name = "monster";
            monster.Health = 100;
            monster.DamageMaximum = 20;
            monster.AttackBonus = 5;
            
        }
    }

    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public int AttackBonus { get; set; }

        public int Attack()
        {
            //Attack() return an int -randomly determine the amount of damage this Character object inflicted.
            Random random = new Random();
            int damage = random.Next(1, DamageMaximum);

        }
        public int Defend(int damage)
        {
            //Defend(int damage) - deducts the damage from this Character's health
            remainingDefenderHealth = defenderHealth - damage;

        }

    }
}
/*
You will perform two sides of the battle.  The first half of the battle will involve the hero attacking the monster and the monster defending itself.  
The second half of the battle will involve the monster attacking and the hero defending itself.  Just one round -- this is not a fight to the death.

Create a helper method in the Deafult class to display the stats of each character in a Label server control.