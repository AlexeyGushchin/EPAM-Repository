

using Gothic___prequel.Interfaces_and_Enums;

namespace Gothic___prequel
{
    class Wood : AbstractBarrier
    {
        public override Sign Sign => Sign.Wood;
        public override Color Color => Color.Green;
        public override bool Destroyable => true;

        public Wood (Point point) : base(point) { }
        
    }
}
