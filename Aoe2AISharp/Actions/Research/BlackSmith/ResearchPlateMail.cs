using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 歩兵用甲冑を研究します。
    /// </summary>
    public class ResearchPlateMail :Research
    {
        /// <summary>
        /// 歩兵用甲冑を研究します。
        /// </summary>
        public ResearchPlateMail() : base(ri.plate_mail)
        {
            Facts.Add(
                new town_under_attack(),
                new unit_type_count_total(unit.InfantryGroup, relop.ge, 10)
                );
        }
    }
}