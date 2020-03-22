using LibAoe2AISharp.Specifications;
using System;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 指定の保有量になった資源を、指定の金の保有量になるか指定の保有量以下になるまで売ります
    /// </summary>
    public class SellSurplusCommodity : defrule
    {
        /// <summary>
        /// 指定の保有量になった資源を、指定の金の保有量になるか指定の保有量以下になるまで売ります
        /// </summary>
        /// <param name="commodity">売る資源</param>
        /// <param name="needAmount">必要な資源の保有量</param>
        /// <param name="LimitationGoldAmount">売りをやめる金の保有量</param>
        public SellSurplusCommodity(commodity commodity, short needAmount, short LimitationGoldAmount)
        {
            AIFactRelOp sellCommodityAmount;
            switch (commodity) {
            case commodity.food:
                sellCommodityAmount = new food_amount(relop.ge, needAmount);
                break;
            case commodity.stone:
                sellCommodityAmount = new stone_amount(relop.ge, needAmount);
                break;
            case commodity.wood:
                sellCommodityAmount = new wood_amount(relop.ge, needAmount);
                break;
            default:
                throw new Exception();
            }

            Facts.Add(
                new can_sell_commodity(commodity),
                new gold_amount(relop.le, LimitationGoldAmount),
                sellCommodityAmount
                );
            Actions.Add(new sell_commodity(commodity));
        }
    }

}