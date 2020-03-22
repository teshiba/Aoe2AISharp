using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    internal class TrainSkirmisher : Train
    {
        /// <summary>
        /// 指定の数まで散兵を生産します。
        /// </summary>
        /// <param name="count">生産数</param>
        public TrainSkirmisher(short count)
            : base(unit.skirmisher_line, count)
        {
            Facts.Add(
                 new ResourceAmount(building.house, building.lumber_camp).Wood,
                 new ResourceAmount(unit.skirmisher_line, unit.villager).Food,
                !new ResourceAmount(ri.castle_age, unit.archer_line, unit.archer_line).Gold,
                 new unit_type_count_total(unit.knight_line, relop.lt, 5),
                (
                   !new players_unit_type_count(player_number.any_enemy, unit.knight_line, relop.ge, 5)
                 |  new players_unit_type_count(player_number.any_enemy, unit.ArcherGroup, relop.ge, 15)
                 | !new players_unit_count(player_number.any_enemy, relop.ge, 20)
                 )
                );
        }
    }
}