using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 荷車の研究を行います。
    /// </summary>
    public class ResearchHandCart :Research
    {
        /// <summary>
        /// 荷車の研究を行います。
        /// </summary>
        public ResearchHandCart() : base(ri.hand_cart)
        {
        }
    }
}