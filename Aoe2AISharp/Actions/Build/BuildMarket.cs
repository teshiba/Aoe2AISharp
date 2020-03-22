using LibAoe2AISharp.Specifications;
using LibAoe2AISharp.Framework;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 同盟の状態ごとに市場を建築するルールを決めます
    /// </summary>
    public class BuildMarket : BuildMarketCondition
    {
        /// <summary>
        /// 同盟の状態ごとに市場を建築するルールを決めます
        /// </summary>
        /// <param name="count">建築する最大数</param>
        public BuildMarket(short count) : base(count)
        {
            NoAllyInGame = new wood_amount(relop.ge, 800)
                & new building_type_count_total(building.archery_range, relop.ge, 2);

            AllyInGame = new building_type_count_total(building.archery_range, relop.ge, 2);

            AllyHasMarket = new building_type_count_total(building.archery_range, relop.ge, 1);
        }
    }
}