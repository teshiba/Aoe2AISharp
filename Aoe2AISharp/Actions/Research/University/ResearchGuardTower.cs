using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 監視塔の研究を行います。
    /// </summary>
    public class ResearchGuardTower :Research
    {
        /// <summary>
        /// 塔があれば監視塔の研究を行います。
        /// </summary>
        public ResearchGuardTower() : base(ri.guard_tower)
        {
            Facts.Add(
                new building_type_count_total(building.watch_tower_line, relop.ge, 1)
                );
        }
    }
}