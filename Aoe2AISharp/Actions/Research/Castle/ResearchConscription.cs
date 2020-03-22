using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 徴用の研究を行います。
    /// </summary>
    public class ResearchConscription :Research
    {
        /// <summary>
        /// 徴用の研究を行います。
        /// </summary>
        public ResearchConscription() : base(ri.conscription)
        {
        }
    }
}