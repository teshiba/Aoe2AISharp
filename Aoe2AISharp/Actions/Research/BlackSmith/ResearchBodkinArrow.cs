using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 錐状矢じりの研究を行います。
    /// </summary>
    public class ResearchBodkinArrow :Research
    {
        /// <summary>
        /// 錐状矢じりの研究を行います。
        /// </summary>
        public ResearchBodkinArrow() : base(ri.bodkin_arrow)
        {
            Facts.Add(
                new town_under_attack(),
                new unit_type_count_total(unit.ArcherGroup, relop.ge, 10));
        }
    }
}