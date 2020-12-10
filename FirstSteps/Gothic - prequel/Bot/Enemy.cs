using Gothic___prequel.Interfaces_and_Enums;


namespace Gothic___prequel.Bot
{
    public class Enemy : AbstractEnemy
    {
        public override int Damage { get; set; }

        public override int Health { get; set; }

        public override int Armor { get; set; }


        public override int BonusExperiense => 20;

        public override int BonusHealth => 0;


        public override Sign Sign => Sign.Enemy;
        public override Color Color => Color.Red;
        public override bool Destroyable => true;



        public Enemy (Point point) : base(point) 
        {
            Damage = 5;
            Health = 10;
            Armor = 10;

        }


    }
}
