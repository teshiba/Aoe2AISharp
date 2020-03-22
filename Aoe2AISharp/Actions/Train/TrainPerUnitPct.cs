using System;
using System.Collections.ObjectModel;
using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using LibAoe2AISharp.Utilty;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    /// <summary>
    /// 指定の比較対象ユニットの生産割合にあわせて、生産対象ユニットを指定の数生産する。
    /// </summary>
    public class TrainPerUnitPct : Collection<TrainPerUnitCount>
    {
        /// <summary>
        /// 指定の比較対象ユニットの生産割合にあわせて、生産対象ユニットを指定の数生産する。
        /// </summary>
        /// <param name="trainUnit">生産対象ユニット</param>
        /// <param name="count">生産対象ユニットの生産数</param>
        /// <param name="comparisonUnit">比較対象ユニット</param>
        /// <param name="percent">比較対象に対する生産対象ユニットの割合[％]</param>
        public TrainPerUnitPct(unit trainUnit, short count,
                                unit comparisonUnit, short percent)
        {
            for (short i = 1; i <= count; i++) {
                Add(new TrainPerUnitCount(trainUnit, i, comparisonUnit,
                                (short)((count - 1) * 100 / percent)));
            }
        }
    }

    /// <summary>
    /// 指定の比較対象ユニットの生産割合にあわせて、生産対象ユニットを指定の数生産する。
    /// </summary>
    public class TrainPerUnitCount : Train
    {
        /// <summary>
        /// 比較対象ユニットが指定の数になったら、指定のユニットを指定の数生産する。
        /// </summary>
        /// <param name="trainUnit">生産対象ユニット</param>
        /// <param name="count">生産対象ユニットの生産数</param>
        /// <param name="comparisonUnit">比較対象ユニット</param>
        /// <param name="comparisonCount">比較対象ユニットの生産数</param>
        public TrainPerUnitCount(unit trainUnit, short count,
                                unit comparisonUnit, short comparisonCount)
            : base(trainUnit, count)
        {
            if (count < 1)
                throw new ArgumentNullException("count", "生産数が１より小さい値が指定されました。");
            if (comparisonCount < 1)
                throw new ArgumentNullException("percent", "生産数が１より小さい値が指定されました");

            Comment += ":" + comparisonUnit.ToLocalLang() + "が" + comparisonCount + "体";

            Facts.Add(new unit_type_count_total(comparisonUnit, relop.ge, comparisonCount));
        }
    }
}