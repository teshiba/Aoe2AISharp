using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 破城槌を生産します。
    /// </summary>
    public class TrainRam :Train
    {
        /// <summary>
        /// 破城槌を指定の数生産します。
        /// </summary>
        public TrainRam(short count) : base(unit.battering_ram_line, count)
        {
            Facts.Add(
                 new ResourceAmount(building.lumber_camp),
                 new ResourceAmount(unit.knight).Gold,
                !new town_under_attack(),
                 ( new players_unit_type_count(player_number.any_enemy, unit.knight_line, relop.le, 5)
                 | new unit_type_count(unit.knight_line, relop.ge, 10)
                 )
            );
        }
    }
}