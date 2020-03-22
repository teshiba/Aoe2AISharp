using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 畑が遠くなったら粉引き所を建設します。
    /// </summary>
    public class BuildMill : LibAoe2AISharp.Framework.BuildMill
    {
        /// <summary>
        /// 畑が遠くなったら粉引き所を建設します。
        /// </summary>
        public BuildMill()
        {
            Distance = 3;
            Facts.Add(new ResourceAmount(building.house, building.mill, building.archery_range));
        }

        /// <summary>
        /// 食料を見つけた条件によって指定の数まで粉引き所を立てます。
        /// </summary>
        public BuildMill(short CountMax) : base(CountMax)
        {
            Comment += "：遠方の食料";

            Facts.Add(new game_time(relop.ge, 150),
                  new building_type_count_total(building.mill, relop.lt, 3)
                | new ResourceAmount(building.mill, building.archery_range, building.house, building.farm)
                );
        }
    }
}