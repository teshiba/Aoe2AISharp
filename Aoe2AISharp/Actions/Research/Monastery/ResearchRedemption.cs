using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 贖いの研究を行います。
    /// </summary>
    public class ResearchRedemption :Research
    {
        /// <summary>
        /// 贖いの研究を行います。
        /// </summary>
        public ResearchRedemption() : base(ri.redemption)
        {
            Facts.Add(
                new gold_amount(relop.ge, 1000));
        }
    }
}