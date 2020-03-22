using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 異端の研究を行います。
    /// </summary>
    public class ResearchHeresy :Research
    {
        /// <summary>
        /// 異端の研究を行います。
        /// </summary>
        public ResearchHeresy() : base(ri.heresy)
        {
            Facts.Add(
                new gold_amount(relop.ge, 500));
        }
    }
}