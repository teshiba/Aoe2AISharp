using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 騎馬用甲冑を研究します。
    /// </summary>
    public class ResearchPlateBarding :Research
    {
        /// <summary>
        /// 騎馬用甲冑を研究します。
        /// </summary>
        public ResearchPlateBarding() : base(ri.plate_barding)
        {
            Facts.Add(
                new town_under_attack(),
                new unit_type_count_total(unit.CavalryGroup, relop.ge, 10)
                );
        }
    }
}