using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 金の採掘の研究を行います。
    /// </summary>
    public class ResearchGoldMining : Research
    {
        /// <summary>
        /// 金の採掘の研究を行います。
        /// </summary>
        public ResearchGoldMining() : base(ri.gold_mining)
        {
        }
    }
}