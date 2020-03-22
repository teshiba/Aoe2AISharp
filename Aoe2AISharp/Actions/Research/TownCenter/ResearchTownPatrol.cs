using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 巡回の研究を行います。
    /// </summary>
    public class ResearchTownPatrol :Research
    {
        /// <summary>
        /// 巡回の研究を行います。
        /// </summary>
        public ResearchTownPatrol() : base(ri.town_patrol)
        {
            Facts.Add(
                new building_type_count_total(building.town_center, relop.ge, 3)
                );
        }
    }
}