using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 強化破城槌の研究を行います。
    /// </summary>
    public class ResearchCappedRam :Research
    {
        /// <summary>
        /// 強化破城槌の研究を行います。
        /// </summary>
        public ResearchCappedRam() : base(ri.capped_ram)
        {
        }
    }
}