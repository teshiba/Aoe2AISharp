using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 包囲攻撃技術の研究を行います。
    /// </summary>
    public class ResearchSiegeEngineers :Research
    {
        /// <summary>
        /// 包囲攻撃技術の研究を行います。
        /// </summary>
        public ResearchSiegeEngineers() : base(ri.siege_engineers)
        {
        }
    }
}