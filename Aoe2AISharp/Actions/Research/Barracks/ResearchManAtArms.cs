using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 軍平の研究を行います。
    /// </summary>
    public class ResearchManAtArms : ResearchUnitNumberCondition
    {
        /// <summary>
        /// 軍平の研究を行います。
        /// </summary>
        public ResearchManAtArms()
            : base(ri.man_at_arms, 5)
        {
        }
    }
}