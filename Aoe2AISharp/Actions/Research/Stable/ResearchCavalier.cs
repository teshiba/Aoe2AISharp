using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 重騎士の研究を行います。
    /// </summary>
    public class ResearchCavalier :Research
    {
        /// <summary>
        /// 重騎士の研究を行います。
        /// </summary>
        public ResearchCavalier() : base(ri.cavalier)
        {
        }
    }
}