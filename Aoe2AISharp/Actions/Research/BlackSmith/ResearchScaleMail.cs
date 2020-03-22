using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 歩兵用うろこの鎧の研究を行います。
    /// </summary>
    public class ResearchScaleMail :Research
    {
        /// <summary>
        /// 歩兵用うろこの鎧の研究を行います。
        /// </summary>
        public ResearchScaleMail() : base(ri.scale_mail)
        {
            Facts.Add(
                 new town_under_attack(),
                 new unit_type_count_total(unit.InfantryGroup, relop.ge, 5)
            );
        }
    }
}