using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 小手の研究を行います。
    /// </summary>
    public class ResearchBracer :Research
    {
        /// <summary>
        /// 小手の研究を行います。
        /// </summary>
        public ResearchBracer() : base(ri.bracer)
        {
            Facts.Add(
                new town_under_attack(),
                 new unit_type_count_total(unit.ArcherGroup, relop.ge, 10)
                );
        }
    }
}