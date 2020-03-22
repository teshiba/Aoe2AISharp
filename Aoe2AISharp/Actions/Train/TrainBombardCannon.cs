using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 大砲を生産します。
    /// </summary>
    public class TrainBombardCannon : Train
    {
        /// <summary>
        /// 大砲を生産します。
        /// </summary>
        public TrainBombardCannon() : base(unit.bombard_cannon)
        {
        }
    }
}