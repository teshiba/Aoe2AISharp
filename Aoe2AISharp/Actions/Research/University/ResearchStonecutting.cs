using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 人力起重機の研究を行います。
    /// </summary>
    public class ResearchStonecutting :Research
    {
        /// <summary>
        /// 人力起重機の研究を行います。
        /// </summary>
        public ResearchStonecutting() : base(ri.stonecutting)
        {
            Facts.Add(
                new food_amount(relop.ge, 600),
                new wood_amount(relop.ge, 400)
                );

        }
    }
}