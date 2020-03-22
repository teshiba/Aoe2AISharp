using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 建築学を研究します。
    /// </summary>
    public class ResearchArchitecture :Research
    {
        /// <summary>
        /// 建築学を研究します。
        /// </summary>
        public ResearchArchitecture() : base(ri.architecture)
        {
        }
    }
}