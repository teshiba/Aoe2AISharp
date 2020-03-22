using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Framework.EachAgesCommandCollection;

namespace Aoe2AISharp
{
    internal class ImperialAge : PerFile
    {
        protected override CommandGroupCollection GetCommandGroups()
        {
            ///////////////////////////////////////////////////////////////////
            var rulesInImperialAgeOnly = new EachAgesCommandCollection(GroupType.ImperialAge,
                "帝王の時代にのみ適用するルール") {
                new InitImperialAge(),                  //帝王の時代の初期設定
                new TrainVillager(200),                 //町の人を指定人数まで生産
                new BuildMonastery(5),                  //神殿の建設
                new BuildSiegeWorkshop(20),              //包囲攻撃訓練所の建設
                new TrainArcherLine(40),                //射手の生産
                new AttackNow(60,90),                   //攻撃
                new ImperialAgeGathererPercentages(),   //帝王の時代の資源収集割合
                new ExtendTownSizeForBuildings(1,100),  //建物を建てるために町のサイズを拡張する
                new TrainScorpion(),                    //スコーピオンの生産
                new ResearchCoinage(),                  //貨幣制度の研究
                new ResearchBanking(),                  //銀行取引
                new ResearchGuilds(),                   //組合
                new ResearchSpiesTreason(),             //謀報/反逆の研究

                new ResearchFervor(),                   //篤信の研究
                new ResearchRedemption(),               //贖い
                new ResearchAtonement(),                //償い
                new ResearchHerbalMedicine(),           //薬草学
                new ResearchHeresy(),                   //異端
                new ResearchStonecutting(),             //人力起重機
                new ResearchGuardTower(),               //監視塔

            };

            ///////////////////////////////////////////////////////////////////
            var internalAffairsInImperial = new CommandCollection("帝王の時代の内政") {
                new ResearchTwoManSaw(),    //両ひきのこぎりの研究
                new ResearchCropRotation(), //輪作の研究

                new SellSurplusCommodity(commodity.food, 1200, 1200), //食料があまっていたら売る
                new SellSurplusCommodity(commodity.wood, 1200, 1200), //木があまっていたら売る
                new SellSurplusCommodity(commodity.stone, 1200, 1200), //石があまっていたら売る
                //金が余ったら買う
                new BuyShortageCommodity(commodity.food, 1200, 1200),
                new BuyShortageCommodity(commodity.wood, 1200, 1200),
                new BuyShortageCommodity(commodity.stone,1200, 650),
            };

            ///////////////////////////////////////////////////////////////////
            var militaryInCastleAge = new CommandCollection("帝王の時代の軍事") {
                new ResearchRingArcherArmor(),      //射手用鎖の鎧研究
                new ResearchBracer(),               //小手の研究
                new ResearchBlastFurnace(),         //高温溶鉱炉の研究
                new ResearchPlateBarding(),         //騎馬用甲冑の研究
                new ResearchPlateMail(),            //歩兵用甲冑の研究

                new TrainHandCannoneer(),           //砲撃手の生産
                new ResearchArbalest(),             //重石弓射手の研究
                new ResearchParthianTactics(),      //パルティアン戦術の研究

                new ResearchHalberdier(),           //矛槍兵の研究
                new ResearchTwoHandedSwordsman(),   //重剣剣士の研究
                new ResearchChanpion(),             //近衛剣士の研究

                new ResearchHussar(),               //ハサーの研究
                new ResearchCavalier(),             //重騎士の研究
                new ResearchPaladin(),              //近衛騎士の研究

                new TrainBombardCannon(),           //大砲の生産
                new ResearchCappedRam(),            //強化破城槌の研究
                new ResearchSiegeRam(),             //改良強化破城槌の研究
                new ResearchOnager(),               //改良型投石機の研究
                new ResearchSiegeOnager(),          //破城投石機の研究
                new ResearchHeavyScorpion(),        //ヘビースコーピオンの研究

                new ResearchFaith(),                //信仰の研究
                new ResearchIllumination(),         //啓蒙の研究
                new ResearchBlockPrinting(),        //活版印刷
                new ResearchTheocracy(),            //神政
            };

            ///////////////////////////////////////////////////////////////////
            var endOfInperialAge = new CommandCollection("帝王の時代中終盤") {
                new ResearchConscription(),         //徴用の研究
                new ResearchChemistry(),            //化学
                new ResearchArchitecture(),         //建築学
                new ResearchSiegeEngineers(),       //包囲攻撃技術
                new ResearchKeep(),                 //防御塔
                new ResearchBombardTower(),         //砲台

                new ResearchUniqueUnitUpgrade(),    //ユニークユニットの研究
                new ResearchUniqueResearch(),       //ユニークテクノロジの研究
                new TrainTrebuchet(),               //遠投投石機の生産
                new ResearchHoardings(),            //城壁強化の研究
                new ResearchSappers(),              //土木技術の研究

            };

            ///////////////////////////////////////////////////////////////////
            return new CommandGroupCollection() {
                rulesInImperialAgeOnly,
                internalAffairsInImperial,
                militaryInCastleAge,
                endOfInperialAge
            };
        }
    }
}