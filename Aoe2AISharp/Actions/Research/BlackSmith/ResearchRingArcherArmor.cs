using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 射手用鎖の鎧を研究します。
    /// </summary>
    public class ResearchRingArcherArmor :Research
    {
        /// <summary>
        /// 射手用鎖の鎧を研究します。
        /// </summary>
        public ResearchRingArcherArmor() : base(ri.ring_archer_armor)
        {
            Facts.Add(
                new town_under_attack(),
                new unit_type_count_total(unit.ArcherGroup, relop.ge, 10)
                );
        }
    }
}