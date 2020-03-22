using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 神殿を建設します
    /// </summary>
    public class BuildMonastery : Build
    {
        /// <summary>
        /// 神殿を指定の数まで建設します。
        /// </summary>
        /// <param name="count">建設する最大数</param>
        public BuildMonastery(short count)
            : base(building.monastery, count)
        {
            //1つ目は家が立つ木があれば建てる
            var firstMonastery = new Conditions(
                   new building_type_count_total(building.monastery, relop.eq, 0)
                 & new ResourceAmount(building.monastery, building.house).Wood
                );
            //2つ目以上はさらに町の中心が立つ木があれば建てる
            var secondMonasteryOrLater = new Conditions(
                   new building_type_count_total(building.monastery, relop.ge, 2)
                 & new ResourceAmount(building.monastery, building.house, building.town_center, building.siege_workshop).Wood
                );

            Facts.Add(firstMonastery | secondMonasteryOrLater);

        }
    }
}