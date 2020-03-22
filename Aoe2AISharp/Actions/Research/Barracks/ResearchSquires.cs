using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 武者修行の研究を行います。
    /// </summary>
    public class ResearchSquires :Research
    {
        /// <summary>
        /// 武者修行の研究を行います。
        /// </summary>
        public ResearchSquires() : base(ri.squires)
        {
            Facts.Add(
                new unit_type_count_total(unit.spearman_line, relop.ge, 5)
            );
        }
    }
}