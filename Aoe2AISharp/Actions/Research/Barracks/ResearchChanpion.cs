using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 近衛剣士の研究を行います。
    /// </summary>
    public class ResearchChanpion :Research
    {
        /// <summary>
        /// 近衛剣士の研究を行います。
        /// </summary>
        public ResearchChanpion() : base(ri.champion)
        {
        }
    }
}