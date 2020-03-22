using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 追跡術の研究を行います。
    /// </summary>
    public class ResearchTracking :Research
    {
        /// <summary>
        /// 追跡術の研究を行います。
        /// </summary>
        public ResearchTracking() : base(ri.tracking)
        {
            Facts.Add(
                new unit_type_count_total(unit.spearman_line, relop.ge, 5)
                );
        }
    }
}