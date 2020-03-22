using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 歩兵用鎖かたびらの研究を行います。
    /// </summary>
    public class ResearchChainMail :Research
    {
        /// <summary>
        /// 歩兵用鎖かたびらの研究を行います。
        /// </summary>
        public ResearchChainMail() : base(ri.chain_mail)
        {
            Facts.Add(
                new town_under_attack(),
                new unit_type_count_total(unit.InfantryGroup, relop.ge, 10)
                );
        }
    }
}