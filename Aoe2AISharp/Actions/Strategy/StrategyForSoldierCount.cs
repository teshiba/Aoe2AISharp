using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 兵士の数を調整する
    /// </summary>
    public class StrategyForSoldierCount : defrule
    {
        /// <summary>
        /// 兵士の数を調整する
        /// </summary>
        /// <param name="soldierCount">兵士の数</param>
        /// <param name="townSize">タウンサイズ</param>
        public StrategyForSoldierCount(short soldierCount, short townSize)
        {
            Comment = string.Format($"soldier count {soldierCount} : extend town size to {townSize}");
            Facts.Add(new soldier_count(relop.ge, soldierCount));
            if (soldierCount > 50) {
                Actions.Add(new set_strategic_number(sn.task_ungrouped_soldiers, 1));
            }
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