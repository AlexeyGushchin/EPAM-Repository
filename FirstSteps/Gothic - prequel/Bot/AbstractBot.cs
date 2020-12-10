

namespace Gothic___prequel.Bot
{
    public abstract class AbstractBot : AbstractGameObject
    {
        public abstract int Health { get; set; }
        public abstract int Damage { get; set; }
        public abstract int Armor { get; set; }
        


        public AbstractBot (Point point) : base(point) { }


    }
}
