using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// パルティアン戦術の研究を行います。
    /// </summary>
    public class ResearchParthianTactics :Research
    {
        /// <summary>
        /// パルティアン戦術の研究を行います。
        /// </summary>
        public ResearchParthianTactics() : base(ri.parthian_tactics)
        {
        }
    }
}