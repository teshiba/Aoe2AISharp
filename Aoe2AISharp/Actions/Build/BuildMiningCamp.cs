using System;
using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 採掘所を建設します
    /// </summary>
    public class BuildMiningCamp : LibAoe2AISharp.Framework.BuildMiningCamp
    {
        /// <summary>
        /// 採掘所を指定された数まで建設します。
        /// </summary>
        /// <param name="count">建設する最大数</param>
        public BuildMiningCamp(short count) : base(count)
        {
        }

        /// <summary>
        /// 金または石と採掘所の距離が指定の値まで離れると採掘所を指定の数建設します。
        /// </summary>
        public BuildMiningCamp()
        {
            Distance = 3;
            Facts.Add(
                new ResourceAmount(building.house, building.mining_camp),
                new building_type_count_total(building.mining_camp, relop.ge, 3));
        }

        /// <summary>
        /// 最初の2件の採掘所は金と石それぞれ掘る人が割り当てられたら採掘所を建設します
        /// </summary>
        public BuildMiningCamp(resource_type resourceType)
            : base(2)
        {
            short   buildingCount;
            sn      resGathererPct;

            switch (resourceType) {
            case resource_type.gold:
                buildingCount = 0;
                Comment += string.Format($"：{buildingCount + 1}軒目（金）");
                resGathererPct = sn.gold_gatherer_percentage;
                break;
            case resource_type.stone:
                buildingCount = 1;
                resGathererPct = sn.stone_gatherer_percentage;
                Comment += string.Format($"：{buildingCount + 1}軒目（石）");
                break;
            case resource_type.food:
            case resource_type.wood:
            default:
                throw new ArgumentException("resourceType");
            }

            Facts.Add(
                new strategic_number(resGathererPct, relop.ge, 1),
                new building_type_count_total(building.archery_range, relop.ge, buildingCount),
                new building_type_count_total(building.mining_camp, relop.eq, buildingCount)
                );
        }
    }
}