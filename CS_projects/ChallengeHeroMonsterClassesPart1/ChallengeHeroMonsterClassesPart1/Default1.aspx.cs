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
                character.Name, character.Health, character.DamageMaximum, character.AttackBonus);
        }
    protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();
            hero.Name = "Hero";
            hero.Health = 30;
            hero.DamageMaximum = 15;
            hero.AttackBonus = 10;

            Character monster = new Character();
            monster.Name = "Monster";
            monster.Health = 30;
            monster.DamageMaximum = 20;
            monster.AttackBonus = 5;

            //hero attacks monster and monster defends
            int heroDamage = hero.Attack();
            monster.Defend(heroDamage);

            //monster attacks hero and hero defends
            int monsterDamage = monster.Attack();
            hero.Defend(monsterDamage);

            characterStats(hero);
            characterStats(monster);
        }
    }

    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public int AttackBonus { get; set; }

        public int Attack()
        {
            Random random = new Random();
            int characterDamage = random.Next(1, DamageMaximum);
            return characterDamage;
        }

        public int Defend(int characterDamage)
        {
            Health = Health - characterDamage;
            return Health;
        }
    }
}
