using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 石の掘削の研究を行います。
    /// </summary>
    public class ResearchStoneShaftMining :Research
    {
        /// <summary>
        /// 石の掘削の研究を行います。
        /// </summary>
        public ResearchStoneShaftMining() : base(ri.stone_shaft_mining)
        {
            //金の掘削の研究が終わってから
            Facts.Add(!new research_available(ri.gold_shaft_mining));
        }
    }
}