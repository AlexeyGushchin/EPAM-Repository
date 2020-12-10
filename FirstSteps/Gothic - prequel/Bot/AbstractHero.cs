using Gothic___prequel.Interfaces;

namespace Gothic___prequel.Bot
{
    public abstract class AbstractHero : AbstractBot, IUpgradeable
    {
        public abstract int Experiense { get; set; }

        public AbstractHero (Point point) : base(point) { }

        public abstract void LevelUp();
    }
}
