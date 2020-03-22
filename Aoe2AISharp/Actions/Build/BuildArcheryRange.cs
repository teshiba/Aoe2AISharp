using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 資源が余っていたら射手育成所を建設します。
    /// </summary>
    public class BuildArcheryRange : Build
    {
        /// <summary>
        /// 射手育成所を指定の数建設します
        /// </summary>
        /// <param name="count">建設する数</param>
        public BuildArcheryRange(short count)
            : base(building.archery_range, count)
        {
        }

        /// <summary>
        /// 資源が余っていたら射手育成所を建設します。
        /// </summary>
        public BuildArcheryRange() : base(building.archery_range)

        {
            Comment += ":資源余り";
            Facts.Add(
                new building_type_count_total(building.town_center, relop.ge, 2),
                new building_type_count_total(building.university, relop.ge, 1),
                new ResourceAmount(building.house, building.archery_range, building.siege_workshop,
                        unit.archer_line, unit.archer_line, unit.villager).Wood
                );
        }
    }
}