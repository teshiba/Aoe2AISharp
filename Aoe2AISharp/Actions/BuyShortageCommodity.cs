﻿using LibAoe2AISharp.Specifications;
using System;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 指定の金の保有量になったら、指定の資源を指定の保有量になるまで売ります
    /// </summary>
    public class BuyShortageCommodity : defrule
    {
        /// <summary>
        /// 指定の金の保有量になったら、指定の資源を指定の保有量になるまで売ります
        /// </summary>
        /// <param name="commodity">売る資源</param>
        /// <param name="needGoldAmount">必要な金の保有量</param>
        /// <param name="LimitationAmount">買いをやめる資源の保有量</param>
        public BuyShortageCommodity(commodity commodity, short needGoldAmount, short LimitationAmount)
        {
            AIFactRelOp buyCommodityAmount = commodity switch {
                commodity.food => new food_amount(relop.le, LimitationAmount),
                commodity.stone => new stone_amount(relop.le, LimitationAmount),
                commodity.wood => new wood_amount(relop.le, LimitationAmount),
                _ => throw new Exception(),
            };
            Facts.Add(
                new can_buy_commodity(commodity),
                new gold_amount(relop.ge, needGoldAmount),
                buyCommodityAmount
                );
            Actions.Add(new buy_commodity(commodity));
        }
    }

}