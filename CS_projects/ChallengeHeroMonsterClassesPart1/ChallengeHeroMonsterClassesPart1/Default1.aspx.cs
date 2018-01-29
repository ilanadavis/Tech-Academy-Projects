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
        public void characterStats(Character character)
        {
            resultLabel.Text += string.Format("<p>Name: {0}, Health: {1}, DamageMaximum: {2}, AttackBonus: {3}", 
                character.Name, character.Health, character.DamageMaximum, character.AttackBonus.ToString());
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();
            hero.Name = "Hero";
            hero.Health = 30;
            hero.DamageMaximum = 15;
            hero.AttackBonus = true;

            Character monster = new Character();
            monster.Name = "Monster";
            monster.Health = 30;
            monster.DamageMaximum = 20;
            monster.AttackBonus = false;

            Dice heroRoll = new Dice();
            Dice monsterRoll = new Dice();

            //battle loop fight to death. Only break out when one or both is <= 0
            while (hero.Health > 0 && monster.Health > 0)
            {
                if (hero.AttackBonus == true) monster.Defend(hero.Attack(heroRoll));
                if (monster.AttackBonus == true) hero.Defend(monster.Attack(monsterRoll));

                //hero attacks monster and monster defends
                int heroDamage = hero.Attack(heroRoll);
                monster.Defend(heroDamage);

                //monster attacks hero and hero defends
                int monsterDamage = monster.Attack(monsterRoll);
                hero.Defend(monsterDamage);

                //display of stats and results
                characterStats(hero);
                characterStats(monster);
                displayResult(hero.Health, monster.Health);
            }
        }
   
        //print results. Hero defeated Monster or visa versa or both died. Using character stats and put it inside each iteration
        private void displayResult(int heroHealth, int monsterHealth)
        {
            if (monsterHealth <= 0 && heroHealth <= 0)
                resultLabel.Text += "<h3>They both lose!!</h3>";
            else if (monsterHealth <= 0)
                resultLabel.Text += "<h3>Hero wins!</h3>";
            else if (heroHealth <= 0)
                resultLabel.Text += "<h3>Monster wins!</h3>";
            else { }
                   
        }
}

    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public int Attack(Dice characterRoll)
        {
            characterRoll.Sides = DamageMaximum; return characterRoll.Roll();
        }

        public int Defend(int characterDamage)
        {
            Health = Health - characterDamage; return Health;
        }
    }

    public class Dice
    {
        public int Sides { get; set; }
        //max damage = to number of sides on the dice
        Random random = new Random();

        //Roll() method will use the Sides property as the max value used by random.next method()
       public int Roll()
        {
            int characterRoll = random.Next(1, Sides); return characterRoll;
        }
    }
}
