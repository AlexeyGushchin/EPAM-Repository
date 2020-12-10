using Gothic___prequel.Interfaces_and_Enums;


namespace Gothic___prequel.Bot
{
    class Beliar : AbstractEnemy
    {
        public override int Damage { get; set; }

        public override int Health { get; set; }

        public override int Armor { get; set; }



        public override int BonusExperiense => 200;

        public override int BonusHealth => 0;



        public override Sign Sign => Sign.Beliar;

        public override Color Color => Color.DarkRed;

        public override bool Destroyable => true;



        public Beliar (Point point) : base(point) 
        {
            Damage = 50;
            Health = 100;
            Armor = 100;
        }
    }
}
