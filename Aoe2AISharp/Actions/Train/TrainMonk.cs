using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 聖職者を生産します。
    /// </summary>
    public class TrainMonk : Train
    {
        /// <summary>
        /// 聖職者を生産します。
        /// </summary>
        public TrainMonk(short count) : base(unit.monk, count)
        {
        }
    }
}