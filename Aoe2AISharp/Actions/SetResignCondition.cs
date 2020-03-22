using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// 降参する条件を設定します
    /// </summary>
    internal class ResignCondition : defrule
    {
        /// <summary>
        /// 降参する条件を設定します
        /// </summary>
        /// <param name="condition">降参する条件</param>
        public ResignCondition(ICondition condition)
        {
            Comment = "降参：" + condition.Comment;
            Facts.Add(condition);
            Actions.Add(new resign());
        }
    }
}