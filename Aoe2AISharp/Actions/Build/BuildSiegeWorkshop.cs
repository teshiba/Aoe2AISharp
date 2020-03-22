using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using System.Collections.Generic;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 包囲攻撃訓練所を建設します。
    /// </summary>
    public class BuildSiegeWorkshop : Build
    {
        /// <summary>
        /// 包囲攻撃訓練所を指定の数まで建設します。
        /// </summary>
        /// <param name="count">建設する最大数</param>
        public BuildSiegeWorkshop(short count)
            : base(building.siege_workshop, count)
        {
            Facts.Add(
                new ResourceAmount(building.siege_workshop, building.house).Wood,
                (
                 (new players_unit_type_count(player_number.any_enemy, unit.ArcherGroup, relop.ge, 10))
                 |
                 (new building_type_count_total(building.town_center, relop.ge, 2)
                  & new soldier_count(relop.ge, 10)
                 )
                )
                );
        }
    }
}