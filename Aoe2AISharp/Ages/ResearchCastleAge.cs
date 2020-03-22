using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 城主の時代に進化します。
    /// </summary>
    public class ResearchCastleAge : ResearchAge
    {
        /// <summary>
        /// 城主の時代に進化します。
        /// </summary>
        public ResearchCastleAge() : base(age.castle_age)
        {
            Actions.Add(new SetGathererRateCollection(30, 50, 15, 5),
                           new set_strategic_number(sn.stone_dropsite_distance, 5));
        }
    }
}