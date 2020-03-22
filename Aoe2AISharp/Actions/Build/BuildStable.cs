using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 騎兵育成所を建設します。
    /// </summary>
    public class BuildStable : Build
    {
        /// <summary>
        /// 騎兵育成所を指定の数になるまで建設します。
        /// </summary>
        /// <param name="count">戦士育成所の最大数</param>
        public BuildStable(short count) : base(building.stable, count)
        {
            Facts.Add(new ResourceAmount(building.house, building.stable));
        }

        /// <summary>
        /// 資源が余っていたら騎兵育成所を建設します。
        /// </summary>
        public BuildStable() : base(building.stable)
        {
            Facts.Add(
                new building_type_count_total(building.town_center, relop.ge, 2),
                new building_type_count_total(building.university, relop.ge, 1),
                new ResourceAmount(building.house, building.stable, building.siege_workshop).Wood,
                new ResourceAmount(unit.villager, unit.knight, unit.knight)
                );
        }
    }
}