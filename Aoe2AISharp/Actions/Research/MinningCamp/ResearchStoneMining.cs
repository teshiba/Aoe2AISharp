using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 石の切り出しの研究を行います。
    /// </summary>
    public class ResearchStoneMining :Research
    {
        /// <summary>
        /// 石の切り出しの研究を行います。
        /// </summary>
        public ResearchStoneMining() : base(ri.stone_mining)
        {
            Facts.Add(new food_amount(relop.ge, 500));
        }
    }
}