using Gothic___prequel.Interfaces_and_Enums;

namespace Gothic___prequel.Bonuses
{
    class Coin : AbstractBonus
    {
        public override int BonusExperiense => 5;

        public override int BonusHealth => 1;

        public override Sign Sign => Sign.Coin;
        public override Color Color => Color.DarkYellow;
        public override bool Destroyable => true;



        public Coin (Point point) : base(point) { }

    }
}
