using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 機織りの研究を行います
    /// </summary>
    public class ResearchLoom :Research
    {
        /// <summary>
        /// 機織りの研究を行います
        /// </summary>
        /// <param name="villagerCount"></param>
        public ResearchLoom(short villagerCount) :base(ri.loom)
        {
            //町の人が生産できないとき、または猪狩りに行く前に研究を行う
            Facts.Add(
                 !new can_train(unit.villager)
                | new unit_type_count(unit.villager, relop.ge, villagerCount)
                );
        }

    }
}