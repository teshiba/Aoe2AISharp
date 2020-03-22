using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 石工技術の研究を行います。
    /// </summary>
    public class ResearchMasonry :Research
    {
        /// <summary>
        /// 石工技術の研究を行います。
        /// </summary>
        public ResearchMasonry() : base(ri.masonry)
        {
        }
    }
}