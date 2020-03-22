using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 伐採所を建設する
    /// </summary>
    public class BuildLumberCamp : LibAoe2AISharp.Framework.BuildLumberCamp
    {
        /// <summary>
        /// 森と伐採所の距離が指定の値まで離れると伐採所を指定の数建設します。
        /// </summary>
        public BuildLumberCamp()
        {
            Distance = 3;
            Facts.Add(
                  new building_type_count_total(building.lumber_camp, relop.ge, 3)
                & new ResourceAmount(building.house, building.lumber_camp)
                );
        }

        /// <summary>
        /// 伐採所を指定の数建設します。
        /// </summary>
        public BuildLumberCamp(short count) : base(count)
        {
            var oneLumberCamp = new Conditions(
                  new building_type_count_total(building.lumber_camp, relop.eq, 0)
                & new building_type_count_total(building.mill, relop.ge, 1)
            );
            var twoLumberCamp = new Conditions(
                  new building_type_count_total(building.lumber_camp, relop.eq, 1)
                & new civilian_population(relop.ge, 20)
            );
            var threeLumberCamp = new Conditions(
                new building_type_count_total(building.lumber_camp, relop.eq, 2)
            );

            Facts.Add(
                  oneLumberCamp | twoLumberCamp | threeLumberCamp,
                  new resource_found(resource_type.wood),
                  new ResourceAmount(building.house, building.lumber_camp),
                  new strategic_number(sn.wood_gatherer_percentage, relop.ge, 1)
               );
        }
    }

}