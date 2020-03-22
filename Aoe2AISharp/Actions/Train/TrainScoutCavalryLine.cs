using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 斥候系列を生産します。
    /// </summary>
    public class TrainScoutCavalryLine : Train
    {
        /// <summary>
        /// 斥候系列を生産します。
        /// </summary>
        public TrainScoutCavalryLine(short count) : base(unit.scout_cavalry_line, count)
        {
            Facts.Add(
                   new food_amount(relop.ge, 800)
                | !new unit_available(unit.knight_line)
            );
        }
    }
    

}