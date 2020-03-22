using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 償いの研究を行います。
    /// </summary>
    public class ResearchAtonement :Research
    {
        /// <summary>
        /// 償いの研究を行います。
        /// </summary>
        public ResearchAtonement() : base(ri.atonement)
        {
            Facts.Add(new gold_amount(relop.ge, 1000));
        }
    }
}