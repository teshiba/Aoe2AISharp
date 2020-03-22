using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 町のサイズを拡張します
    /// </summary>
    public class ExtendTownSizeForBuildings : defrule
    {
        /// <summary>
        /// 町のサイズを拡張します
        /// </summary>
        /// <param name="buildingCount">必要な建物の数</param>
        /// <param name="townSize">町の大きさ</param>
        public ExtendTownSizeForBuildings(short buildingCount, short townSize)
        {
            Comment = string.Format($"build count {buildingCount} : extend town size to {townSize}");
            Facts.Add(
                  new building_count(relop.ge, buildingCount)
            );
            Actions.Add(new set_strategic_number(sn.maximum_town_size, townSize),
                           new set_strategic_number(sn.camp_max_distance, townSize),
                           new set_strategic_number(sn.maximum_gold_drop_distance, townSize),
                           new set_strategic_number(sn.maximum_stone_drop_distance, townSize),
                           new set_strategic_number(sn.maximum_food_drop_distance, townSize),
                           new set_strategic_number(sn.maximum_wood_drop_distance, townSize),
                           new disable_self());
        }
    }
}