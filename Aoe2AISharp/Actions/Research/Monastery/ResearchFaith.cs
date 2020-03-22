using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 信仰の研究を行います。
    /// </summary>
    public class ResearchFaith :Research
    {
        /// <summary>
        /// 信仰の研究を行います。
        /// </summary>
        public ResearchFaith() : base(ri.faith)
        {
        }
    }
}