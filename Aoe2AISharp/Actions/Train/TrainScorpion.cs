using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// スコーピオンを生産します。
    /// </summary>
    public class TrainScorpion :Train
    {
        /// <summary>
        /// スコーピオンを生産します。
        /// </summary>
        public TrainScorpion() : base(unit.scorpion)
        {
            Facts.Add(new town_under_attack());

        }
    }
}