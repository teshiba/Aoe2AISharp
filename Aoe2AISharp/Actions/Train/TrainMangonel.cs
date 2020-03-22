using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 投石機を生産します。
    /// </summary>
    public class TrainMangonel :Train
    {
        /// <summary>
        /// 投石機を生産します。
        /// </summary>
        public TrainMangonel() : base(unit.mangonel)
        {
            Facts.Add(
                  new town_under_attack()
                | new players_unit_type_count(player_number.any_enemy, unit.ArcherGroup, relop.ge, 10)
                | !new players_unit_type_count(player_number.any_enemy, unit.knight_line, relop.ge, 5)
                );
        }
    }
}