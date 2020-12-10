using Gothic___prequel.Interfaces;


namespace Gothic___prequel.Bot
{
    public abstract class AbstractEnemy : AbstractBot, IReward
    {
        public AbstractEnemy (Point point) : base(point) { }

        public abstract int BonusHealth { get; }
        public abstract int BonusExperiense { get; }
    }
}
