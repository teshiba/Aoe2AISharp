using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 騎兵の研究を行います。
    /// </summary>
    public class ResearchLightCavalry :Research
    {
        /// <summary>
        /// 騎兵の研究を行います。
        /// </summary>
        public ResearchLightCavalry() : base(ri.light_cavalry)
        {
            Facts.Add(
                   new food_amount(relop.ge, 500)
                | !new unit_available(unit.knight_line)
            );
        }
    }
}