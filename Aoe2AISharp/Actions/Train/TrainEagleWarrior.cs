using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// イーグルウォーリアを生産します。
    /// </summary>
    public class TrainEagleWarrior : Train
    {
        /// <summary>
        /// イーグルウォーリアを生産します。
        /// </summary>
        public TrainEagleWarrior(short count) 
            : base(unit.eagle_warrior_line, count)
        {
            Facts.Add(
                new ResourceAmount(unit.eagle_warrior_line, unit.trade_cart).Gold,
                new ResourceAmount(unit.eagle_warrior_line, unit.villager).Food
                );
        }
    }

    
}