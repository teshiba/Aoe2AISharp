using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 迎撃用窓の研究を行います。
    /// </summary>
    public class ResearchMurderHoles :Research
    {
        /// <summary>
        /// 迎撃用窓の研究を行います。
        /// </summary>
        public ResearchMurderHoles() : base(ri.murder_holes)
        {
        }
    }
}