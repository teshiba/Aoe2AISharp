using LibAoe2AISharp.Specifications;
using LibAoe2AISharp.Framework;

namespace Aoe2AISharp
{
    /// <summary>
    /// 剣士を生産します。
    /// </summary>
    public class TrainMilitiamanLine :Train
    {
        /// <summary>
        /// 剣士を生産します。
        /// </summary>
        public TrainMilitiamanLine() 
            : base(unit.militiaman_line, Limit.PopulationMax)
        {
            Facts.Add(
                new ResourceAmount(unit.knight, unit.trade_cart).Gold,
                (
                   new research_completed(ri.two_handed_swordsman)
                 | new research_available(ri.champion)
                )
                );
        }
    }
}