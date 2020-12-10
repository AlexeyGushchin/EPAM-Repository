using Gothic___prequel.Interfaces_and_Enums;


namespace Gothic___prequel.Barrier
{
    class Teleport : AbstractBarrier
    {
        public override bool Destroyable => false;

        public override Sign Sign => Sign.Teleport;

        public override Color Color => Color.DarkBlue;

        public Teleport (Point point) : base(point) { }
        


    }
}
