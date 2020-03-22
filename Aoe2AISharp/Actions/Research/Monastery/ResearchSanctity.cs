using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 神聖の研究を行います。
    /// </summary>
    public class ResearchSanctity :Research
    {
        /// <summary>
        /// 神聖の研究を行います。
        /// </summary>
        public ResearchSanctity() : base(ri.sanctity)
        {
            Facts.Add(
                new unit_type_count_total(unit.monk, relop.ge, 1)
                );
        }
    }
}