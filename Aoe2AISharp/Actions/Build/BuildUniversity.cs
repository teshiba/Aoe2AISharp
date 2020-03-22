using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 学問所を建設します。
    /// </summary>
    public class BuildUniversity : Build
    {
        /// <summary>
        /// 学問所を指定の数になるまで建設します。
        /// </summary>
        public BuildUniversity(short count) 
            : base(building.university, count)
        {
            Facts.Add(
                new ResourceAmount(building.university, building.house),
                new building_type_count_total(
                                building.town_center, relop.ge, 2)
            );
        }
    }

}