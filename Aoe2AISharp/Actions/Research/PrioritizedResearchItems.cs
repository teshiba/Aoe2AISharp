using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using LibAoe2AISharp.Utilty;
using System.Collections.ObjectModel;

namespace Aoe2AISharp
{
    /// <summary>
    /// 研究する順番の条件をつけたルールのコレクションを生成します。
    /// </summary>
    public class PrioritizedResearchItems : Collection<Research>
    {
        /// <summary>
        /// 研究する順番の条件をつけたルールのコレクションを生成します。
        /// </summary>
        /// <param name="researchItems">研究する順番で格納されたテクノロジーの研究ルールの配列</param>
        public PrioritizedResearchItems(params Research[] researchItems)
        {
            //1つ目は無条件で研究を実行
            Add(researchItems[0]);

            for (int i = 1; i < researchItems.Length; i++) {
                var item = researchItems[i];
                //一つ前の研究が有効なときはその研究が優先なのでそれが否定されたら研究可能になる
                item.Facts.Add(!new research_available(researchItems[i - 1].ResearchItem));
                item.Comment = researchItems[i].ResearchItem.ToLocalLang() + " の研究 条件:" + 
                    researchItems[i - 1].ResearchItem.ToLocalLang() + " 研究済み";
                Add(item);
            }
        }
    }
}