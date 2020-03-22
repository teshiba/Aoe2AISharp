using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 血統の研究を行います。
    /// </summary>
    public class ResearchBloodlines :Research
    {
        /// <summary>
        /// 騎士が指定の数いたら血統の研究を行います。
        /// </summary>
        public ResearchBloodlines() : base(ri.bloodlines)
        {
            Facts.Add(
                new town_under_attack(),
                new unit_type_count_total(unit.CavalryGroup, relop.ge, 5)
                );
        }
    }
}