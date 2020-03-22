
using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;



namespace Aoe2AISharp
{
    /// <summary>
    /// 金の掘削の研究を行います。
    /// </summary>
    public class ResearchGoldShaftMining :Research
    {
        /// <summary>
        /// 金の掘削の研究を行います。
        /// </summary>
        public ResearchGoldShaftMining() : base(ri.gold_shaft_mining)
        {
            //荷車の研究が終わってから
            Facts.Add(!new research_available(ri.hand_cart));
        }
    }
}