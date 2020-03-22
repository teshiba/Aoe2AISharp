using LibAoe2AISharp.Utilty;

namespace Aoe2AISharp
{
    class Program
    {
        static void Main(string[] args)
        {
            _ = args;

            //コメントをチャット出力します
            Debug.ChatLocalToSelf = false;
            Debug.ChatToAll = true;
            KeywordDictionary.SetLocalLang(KeywordDictionary.LocalLang.Japanese);

            //RootAIFileクラスを継承したクラスを生成して
            //OutputFiles()で、.aiファイルと関連する.perファイルを出力します。
            new AISharp2(
                @"C:\Program Files (x86)\Steam\steamapps\common\Age2HD\resources\_common\ai",
                "S.T"
                ).OutputFiles();

        }
    }
}
