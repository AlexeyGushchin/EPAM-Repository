using Gothic___prequel.Interfaces_and_Enums;

namespace Gothic___prequel.Barrier
{
    class Teleport2 : Teleport
    {
        public override Sign Sign => Sign.Teleport2;
        public Teleport2 (Point point) : base(point) { }

    }
}
