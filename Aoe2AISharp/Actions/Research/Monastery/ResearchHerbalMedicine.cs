using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 薬草学の研究を行います。
    /// </summary>
    public class ResearchHerbalMedicine :Research
    {
        /// <summary>
        /// 薬草学の研究を行います。
        /// </summary>
        public ResearchHerbalMedicine() : base(ri.HerbalMedicine)
        {
            Facts.Add(
                new gold_amount(relop.ge, 1000));
        }
    }
}