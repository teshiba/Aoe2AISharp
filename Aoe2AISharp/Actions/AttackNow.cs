using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 領主の時代の攻撃
    /// </summary>
    public class AttackNow : defrule
    {
        /// <summary>
        /// 指定人数兵士が生産されたら攻撃を行う。
        /// <para>
        /// 攻撃はタイマーなどを使用して定期的に実行した方がより良い。
        /// </para>
        /// </summary>
        /// <param name="soldierCount">兵士の数</param>
        /// <param name="percent">攻撃に割り当てる人数の割合[%]</param>
        public AttackNow(short soldierCount, short percent)
        {
            Comment += string.Format($":{soldierCount}人 {percent}%");
            Facts.Add(
                 new soldier_count(relop.ge, soldierCount)
                & new unit_type_count(unit.battering_ram_line, relop.ge, 1)
                );

            Actions.Add(
                new set_strategic_number(sn.percent_attack_soldiers, percent),
                new attack_now(),
                new disable_self()
                );
        }
    }
}