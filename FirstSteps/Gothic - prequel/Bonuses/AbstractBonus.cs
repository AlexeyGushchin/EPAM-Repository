

using Gothic___prequel.Interfaces;

namespace Gothic___prequel.Bonuses
{
    abstract class AbstractBonus : AbstractGameObject, IReward
    {
        public abstract int BonusHealth { get; }
        public abstract int BonusExperiense { get; }
        
        public AbstractBonus (Point point) : base(point) { }

    }
}
