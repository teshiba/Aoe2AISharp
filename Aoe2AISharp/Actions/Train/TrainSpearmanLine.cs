using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    internal class TrainSpearmanLine : Train
    {
        /// <summary>
        /// 槍兵を生産します。
        /// </summary>
        public TrainSpearmanLine(short count)
            : base(unit.spearman_line, count)
        {
            Conditions unitCondition =  new players_unit_type_count(
                                            player_number.any_enemy, unit.knight_line, relop.ge, 10);

            Conditions costCondition = new ResourceAmount(building.house, building.lumber_camp)
                                     & new ResourceAmount(unit.villager);

            Facts.Add(unitCondition, costCondition);
        }
    }
}