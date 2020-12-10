

using Gothic___prequel.Interfaces_and_Enums;

namespace Gothic___prequel.Bonuses
{
    class Apple : AbstractBonus
    {
        public override int BonusExperiense => 1;

        public override int BonusHealth => 5;

        public override Sign Sign => Sign.Apple;
        public override Color Color => Color.Yellow;
        public override bool Destroyable => true;

        public Apple (Point point) : base(point) { }

    }
}
