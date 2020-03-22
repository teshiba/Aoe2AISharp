using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 繁殖の研究を行います。
    /// </summary>
    public class ResearchHusbandry :Research
    {
        /// <summary>
        /// 繁殖の研究を行います。
        /// </summary>
        public ResearchHusbandry() : base(ri.husbandry)
        {
            Facts.Add(
                new town_under_attack(),
                new unit_type_count_total(unit.CavalryGroup, relop.ge, 10)
                );
        }
    }
}