using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 城壁強化の研究を行います。
    /// </summary>
    public class ResearchHoardings :Research
    {
        /// <summary>
        /// 城壁強化の研究を行います。
        /// </summary>
        public ResearchHoardings() : base(ri.hoardings)
        {
        }
    }
}