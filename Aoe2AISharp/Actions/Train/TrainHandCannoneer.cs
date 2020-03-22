using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 砲撃手を生産します。
    /// </summary>
    public class TrainHandCannoneer : Train
    {
        /// <summary>
        /// 砲撃手を生産します。
        /// </summary>
        public TrainHandCannoneer() : base(unit.hand_cannoneer)
        {
        }
    }
}