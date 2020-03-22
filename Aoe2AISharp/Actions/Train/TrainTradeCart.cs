using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 荷馬車を生産します。
    /// </summary>
    public class TrainTradeCart :Train
    {
        /// <summary>
        /// 荷馬車を生産します。
        /// </summary>
        public TrainTradeCart(short count)
            : base(unit.trade_cart, count)
        {
            Facts.Add(
                ComplexConditions.AnyAllyHasMarket(),
                new ResourceAmount(building.house, building.town_center).Wood,
                new ResourceAmount(unit.trade_cart).Gold
                );
        }
    }
}