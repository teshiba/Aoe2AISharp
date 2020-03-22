using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 銀行取引を研究します。
    /// </summary>
    public class ResearchBanking :Research
    {
        /// <summary>
        /// 銀行取引を研究します。
        /// </summary>
        public ResearchBanking() : base(ri.banking)
        {
        }
    }
}