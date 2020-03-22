using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 貨幣制度の研究を行います。
    /// </summary>
    public class ResearchCoinage :Research
    {
        /// <summary>
        /// 貨幣制度の研究を行います。
        /// </summary>
        public ResearchCoinage() : base(ri.coinage)
        {
            Facts.Add(
                ComplexConditions.AnyAllyHasMarket()
                );
        }
    }
}