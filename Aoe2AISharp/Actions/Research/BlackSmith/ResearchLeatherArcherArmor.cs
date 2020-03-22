using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 射手用革の鎧の研究を行います。
    /// </summary>
    public class ResearchLeatherArcherArmor :Research

    {
        /// <summary>
        /// 射手用革の鎧の研究を行います。
        /// </summary>
        public ResearchLeatherArcherArmor() : base(ri.leather_archer_armor)
        {
            Facts.Add(
                new town_under_attack(),
                new unit_type_count_total(unit.ArcherGroup, relop.ge, 10)
                );
        }
    }
}