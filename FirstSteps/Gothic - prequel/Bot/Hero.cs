using Gothic___prequel.Interfaces;
using Gothic___prequel.Interfaces_and_Enums;

namespace Gothic___prequel.Bot
{
    class Hero : AbstractHero, IUpgradeable
    {
        int experiense;

        int nextLevel = 100;
        
        public override int Damage { get; set; }

        public override int Health { get; set; }

        public override int Armor { get; set; }

        public override Sign Sign => Sign.Hero;

        public override Color Color => Color.DarkBlue;
        public override bool Destroyable => true;

        public Hero (Point point) : base(point) 
        {
            Damage = 5;
            Health = 10;
            Armor = 10;
            Experiense = 0;
        }

        public override void LevelUp()
        {
            Damage += 2;
            Health += 3;
            Armor += 1;

        }

        public override int Experiense
        {
            get => experiense;
            set
            {
                experiense += value;
                if (experiense >= nextLevel)
                {
                    LevelUp();
                    nextLevel += nextLevel;

                }
            }
        }


    }
}
