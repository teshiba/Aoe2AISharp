using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// ゲーム開始時の軍事ユニットの動作を決めます。
    /// </summary>
    public class InitMilitaryActions : defrule
    {
        /// <summary>
        /// 軍事ユニットのグループは「探索」、「攻撃」、「守備」の３つ。
        /// 軍事ユニットの設定はグループ毎の割合を設定するのではなく、
        /// 各グループのグループ数と1グループの最大・最小人数を設定する。
        /// </summary>
        public InitMilitaryActions()
        {
            Comment = "ゲーム開始時の斥候の動きの設定";
            Actions.Add(
                new set_strategic_number(sn.number_explore_groups, 1),
                new set_strategic_number(sn.minimum_explore_group_size, 1),
                new set_strategic_number(sn.maximum_explore_group_size, 1),
                new set_strategic_number(sn.minimum_civilian_explorers, 0),
                new set_strategic_number(sn.total_number_explorers, 1),
                new set_strategic_number(sn.number_attack_groups, 0),
                new set_strategic_number(sn.minimum_attack_group_size, 15),
                new set_strategic_number(sn.maximum_attack_group_size, 15),
                new set_strategic_number(sn.number_defend_groups, 0),
                new set_strategic_number(sn.minimum_defend_group_size, 10),
                new set_strategic_number(sn.maximum_defend_group_size, 10),

                new set_strategic_number(sn.gather_defense_units, 1),
                new set_strategic_number(sn.task_ungrouped_soldiers, 0),
                new set_strategic_number(sn.group_form_distance, 20),
                new disable_self()
                );
        }
    }
}