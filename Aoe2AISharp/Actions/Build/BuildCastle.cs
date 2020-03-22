using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 城を建設します。
    /// </summary>
    public class BuildCastle : Build
    {
        /// <summary>
        /// 城を建設します。
        /// </summary>
        public BuildCastle() :base(building.castle)
        {
            Facts.Add(
                new building_type_count_total(building.town_center, relop.ge, 2)
              | new ResourceAmount(building.town_center).Stone
              );

            Actions.Add(
                new set_strategic_number(sn.camp_max_distance, 45),
                new set_strategic_number(sn.minimum_town_size, 35)
                );
        }
    }
}
