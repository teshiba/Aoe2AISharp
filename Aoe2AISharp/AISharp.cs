using System.Collections.Generic;
using System.Collections.ObjectModel;
using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;

namespace Aoe2AISharp
{
    /// <summary>
    /// AIのベースになるクラス定義です。
    /// .per , .aiファイルを生成するため、
    /// RootAIFileクラスを継承したクラスを作成します。
    /// </summary>
    class AISharp2 : AIFile
    {
        /// <summary>
        /// コンストラクタでAIファイルの設定と関連するファイルを指定します。
        /// </summary>
        /// <param name="pathName">aiファイルを出力するファイルのパス名を設定</param>
        /// <param name="Author">作成者の名前を設定（任意）</param>
        public AISharp2(string pathName, string Author)
            : base(pathName, Author,
                  //依存関係があるAIFileクラスを継承したクラスを列挙します
                  new DarkAge(),        //AISharp2DarkAge.perファイルとして出力されます
                  new FeudalAge(),      //AISharp2FeudalAge.perファイルとして出力されます
                  new CastleAge(),      //AISharp2CastleAge.perファイルとして出力されます
                  new ImperialAge()     //AISharp2ImperialAge.perファイルとして出力されます
                  )
        {
        }

        /// <summary>
        /// defconst定義を取得します。
        /// </summary>
        /// <remarks>
        /// ユーザー定義したdefconstがある場合はこの関数戻り値に設定してください。
        /// </remarks>
        /// <returns>defconst定義文字列</returns>
        protected override Collection<DefconstCollection> GetDefconsts()
        {
            return new Collection<DefconstCollection>() {
            };

        }

        /// <summary>
        /// ゴールIDの初期値を取得します
        /// </summary>
        /// <remarks>
        /// ユーザー定義したゴールIDを初期化するためのパラメータを
        /// この関数戻り値に設定してください。
        /// </remarks>
        /// <returns>ゴールIDとその初期値</returns>
        protected override Dictionary<GoalId, GoalValue> GetGoalIdInitValues()
        {
            return new Dictionary<GoalId, GoalValue>() {
            };
        }
    }
}
