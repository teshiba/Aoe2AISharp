using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 化学の研究を行います。
    /// </summary>
    public class ResearchChemistry :Research
    {
        /// <summary>
        /// 化学の研究を行います。
        /// </summary>
        public ResearchChemistry() : base(ri.chemistry)
        {
        }
    }
}