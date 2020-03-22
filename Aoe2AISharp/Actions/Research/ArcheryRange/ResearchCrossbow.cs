using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 石弓射手の研究を行います。
    /// </summary>
    public class ResearchCrossbow :ResearchUnitNumberCondition
    {
        /// <summary>
        /// 石弓射手の研究を行います。
        /// </summary>
        public ResearchCrossbow() : base(ri.crossbow, 5)
        {
        }
    }
}