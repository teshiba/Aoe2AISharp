using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 騎馬用鎖かたびらの研究を行います。
    /// </summary>
    public class ResearchChainBarding :Research
    {
        /// <summary>
        /// 騎馬用鎖かたびらの研究を行います。
        /// </summary>
        public ResearchChainBarding() : base(ri.chain_barding)
        {
            Facts.Add(
                new town_under_attack(),
                new unit_type_count_total(unit.CavalryGroup, relop.ge, 10)
                );
        }
    }
}