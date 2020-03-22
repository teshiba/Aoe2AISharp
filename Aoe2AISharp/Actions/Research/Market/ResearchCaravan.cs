using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 隊商の研究を行います。
    /// </summary>
    public class ResearchCaravan :Research
    {
        /// <summary>
        /// 隊商の研究を行います。
        /// </summary>
        public ResearchCaravan() : base(ri.caravan)
        {
            Facts.Add(new unit_type_count_total(unit.trade_cart, relop.ge ,2));
        }
    }
}