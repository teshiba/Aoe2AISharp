using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 射手用胸当ての研究を行います。
    /// </summary>
    public class ResearchPaddedArcherArmor :Research
    {
        /// <summary>
        /// 射手用胸当ての研究を行います。
        /// </summary>
        public ResearchPaddedArcherArmor() : base(ri.padded_archer_armor)
        {
            Facts.Add(
                new town_under_attack(),
                new unit_type_count_total(unit.archer_line, relop.ge, 5)
            );
        }
    }
}