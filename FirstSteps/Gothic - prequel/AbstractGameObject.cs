using Gothic___prequel.Interfaces_and_Enums;


namespace Gothic___prequel
{
    public abstract class AbstractGameObject 
    {
        public Point point;

        public abstract Sign Sign { get; }

        public abstract Color Color { get; }

        public abstract bool Destroyable { get; }

        public AbstractGameObject(Point point)
        {
            this.point = point;
        }
    }
}
