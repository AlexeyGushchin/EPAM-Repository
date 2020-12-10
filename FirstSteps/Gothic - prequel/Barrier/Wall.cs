

using Gothic___prequel.Interfaces_and_Enums;

namespace Gothic___prequel
{
    class Wall : AbstractBarrier
    {
        public override Sign Sign => Sign.Wall;
        public override Color Color => Color.White;
        public override bool Destroyable => false;

        public Wall (Point point) : base(point) { }
        


    }
}
