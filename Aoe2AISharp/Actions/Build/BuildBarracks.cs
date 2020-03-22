using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 戦士育成所を建設します。
    /// </summary>
    public class BuildBarracks : Build
    {
        /// <summary>
        /// 戦士育成所を指定の数になるまで建設します。
        /// </summary>
        /// <param name="count">戦士育成所の最大数</param>
        public BuildBarracks(short count) : base(building.barracks, count)
        {
            Facts.Add(new ResourceAmount(building.house, building.barracks),
                 new building_type_count_total(building.barracks, relop.eq, 0)
                |
                 (new building_type_count_total(building.barracks, relop.eq, 1)
                  & new building_type_count_total(building.archery_range, relop.ge, 2)
                 )
                |
                 (new building_type_count_total(building.barracks, relop.ge, 2)
                  & new building_type_count_total(building.town_center, relop.ge, 2)
                 )
                );
        }

        /// <summary>
        /// 資源が余っていたら戦士育成所を建設します。
        /// </summary>
        public BuildBarracks() :base(building.barracks)
        {
            Comment += ":資源余り";
            Facts.Add(
                new building_type_count_total(building.town_center, relop.ge, 2),
                new building_type_count_total(building.university, relop.ge, 1),
                new ResourceAmount(building.house, building.barracks, building.siege_workshop),
                new ResourceAmount(unit.villager, unit.militiaman_line, unit.militiaman_line).Food
                );
        }
    }
}