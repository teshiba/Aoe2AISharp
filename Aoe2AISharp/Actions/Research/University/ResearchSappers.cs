using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 土木技術の研究を行います。
    /// </summary>
    public class ResearchSappers :Research
    {
        /// <summary>
        /// 土木技術の研究を行います。
        /// </summary>
        public ResearchSappers(): base(ri.sappers)
        {
        }
    }
}