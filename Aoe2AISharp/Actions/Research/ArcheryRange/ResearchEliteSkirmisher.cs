using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 精鋭散兵の研究を行います。
    /// </summary>
    public class ResearchEliteSkirmisher : ResearchUnitNumberCondition
    {
        /// <summary>
        /// 精鋭散兵の研究を行います。
        /// </summary>
        public ResearchEliteSkirmisher() : base(ri.elite_skirmisher, 5)
        {
        }
    }
}