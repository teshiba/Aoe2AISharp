using LibAoe2AISharp.Framework;
using LibAoe2AISharp.Specifications;
using static LibAoe2AISharp.Framework.EachAgesCommandCollection;
using static LibAoe2AISharp.Specifications.Ope;

namespace Aoe2AISharp
{
    internal class CastleAge : PerFile
    {
        protected override CommandGroupCollection GetCommandGroups()
        {
            ///////////////////////////////////////////////////////////////////
            var rulesInCastleAgeOnly = new EachAgesCommandCollection(GroupType.CastleAge,
                "城主の時代のみに適用するルール")
            {
                new InitCastleAge(),                    //城主の時代の初期設定
                new TrainVillager(200, age.castle_age), //進化条件を満たすまで町の人の生産
                new CastleAgeGathererPercentages(),
                new BuildSiegeWorkshop(3),              //包囲攻撃訓練所の建設
                new BuildLumberCamp(3),                 //伐採所3つ目まで建てます
                new BuildBarracks(3),                   //戦士育成所の建設
                new TrainArcherLine(20),                //射手の生産
                new ResignTimeout("00:35:00", 5),       //指定の時間経過したら降参
                new BuildMonastery(1),                  //神殿の建設
                new TrainUniqueUnit(5),                 //ユニークユニットの生産
            };

            ///////////////////////////////////////////////////////////////////
            var internalAffairsInCastleAge = new CommandCollection(
                "城主の時代の内政 ～序盤中盤の内政展開～") {
                new ResearchImperialAge(),  //帝王の時代に進化

                new BuildTownCenter(4), //町の中心の増設
                new ResearchPikeman(),  //長槍兵の研究
                new TrainKnight(20),    //騎士の生産
                new ResearchCrossbow(), //石弓射手の研究

                new ResearchGoldShaftMining(),  //金の掘削
                new ResearchStoneShaftMining(), //石の掘削

                new ExtendTownSizeForBuildings(20,10),   //建物を建てるために町のサイズを拡張する
                new ExtendTownSizeForBuildings(30,20),   //建物を建てるために町のサイズを拡張する
                new ExtendTownSizeForBuildings(45,25),   //建物を建てるために町のサイズを拡張する
                new ExtendTownSizeForBuildings(60,30),   //建物を建てるために町のサイズを拡張する
                new ExtendTownSizeForBuildings(75,35),   //建物を建てるために町のサイズを拡張する
                new ExtendTownSizeForBuildings(90,45),   //建物を建てるために町のサイズを拡張する
                new ExtendTownSizeForBuildings(100,50), //建物を建てるために町のサイズを拡張する

                new StrategyForSoldierCount(50,50),   //ユニットが増えてきたら町のサイズを拡張する
                new StrategyForSoldierCount(60,60),   //ユニットが増えてきたら町のサイズを拡張する
                new StrategyForSoldierCount(70,70),   //ユニットが増えてきたら町のサイズを拡張する
                new StrategyForSoldierCount(80,80),   //ユニットが増えてきたら町のサイズを拡張する
                new StrategyForSoldierCount(100,90),   //ユニットが増えてきたら町のサイズを拡張する
                new StrategyForSoldierCount(120,100),   //ユニットが増えてきたら町のサイズを拡張する
            };

            ///////////////////////////////////////////////////////////////////
            var militaryInCastleAge = new CommandCollection(
                "城主の時代の軍事 ～軍の生産と攻撃～") {

                new ResearchBodkinArrow(),      //錐状矢じりの研究
                new ResearchEliteSkirmisher(),  //精鋭散兵の研究
                new ResearchThumbRing(),        //弓懸の研究

                new ResearchScaleMail(),            //歩兵用うろこの鎧
                new ResearchLeatherArcherArmor(),   //射手用革の鎧
                new ResearchChainMail(),            //歩兵用鎖かたびら
                new ResearchTracking(),             //追跡術の研究
                new ResearchSquires(),              //武者修行の研究
                new TrainEagleWarrior(20),          //イーグルウォーリアの生産
                new ResearchLightCavalry(),         //騎兵の研究

                new TrainMonk(5),                  //聖職者の生産
                new ResearchSanctity(),            //神聖の研究

                new AttackNow(50,100),      //兵がたまったら攻撃
                new AttackNow(60,90),       //兵がたまったら攻撃
                new AttackNow(70,90),       //兵がたまったら攻撃
                new TrainSkirmisher(15),    //散兵の生産
                new ResearchCaravan(),      //隊商
            };

            ///////////////////////////////////////////////////////////////////
            var endOfCastlelAge = new CommandCollection("城主の時代中終盤") {

                new BuildUniversity(1),     //学問所の建設
                new ResearchBallistics(),   //弾道学
                new ResearchMasonry(),      //石工技術
                new ResearchHeatedShot(),   //火砲学
                new ResearchMurderHoles(),  //迎撃用窓
                new ResearchFortifiedWall(),//強化壁

                new BuildCastle(),          //城の建設

                new ResearchTownWatch(),    //見張りの研究
                new ResearchTownPatrol(),   //巡回

                new ResearchManAtArms(),     //軍兵の研究
                new ResearchLongSwordsMan(), //長剣剣士の研究
            };

            ///////////////////////////////////////////////////////////////////

            var rulesInCastleAgeOrLater = new EachAgesCommandCollection(GroupType.CastleAgeOrLater,
                 "城主の時代以降に適用するルール") {
                new BuildStable(4),                 //騎兵育成所の建設
                new BuildMill(),                    //粉引き所
                new BuildBarracks(),                //資源が余っていたら戦士育成所を生産
                new TrainSpearmanLine(30),          //槍兵の生産
                new TrainTradeCart(70),             //荷馬車の生産
                new BuildArcheryRange(),            //資源が余っていたら射手育成所を建設
                new TrainMilitiamanLine(),          //剣士を生産します。
                new BuildMiningCamp(4),             //採掘所を4つ目まで建てます
                new TrainMangonel(),                //投石器の生産
                new TrainRam(3),                    //破城槌の生産
                new BuildMill(4),                   //粉ひき所を建設
                new TrainScoutCavalryLine(20),      //斥候
                new TrainCamelLine(20),             //らくだ
                new BuildStable(),                  //騎兵育成所を建設
                new ResearchStoneMining(),          //石の切り出し
                new ResignCondition(                //降参する条件
                    new soldier_count(relop.eq, 1)  //兵士が指定人数以下で資源もなくなってきたら
                    & new food_amount(relop.lt, 50)
                    & new gold_amount(relop.lt, 100)
                    ){ Comment = "攻められた！"},
            };

            ///////////////////////////////////////////////////////////////////
            var rulesToCastlelAgeOnly = new EachAgesCommandCollection(GroupType.CastleAge,
                                                        ResearchState.Researching,
            "帝王の時代進化中にのみ適用するルール") {

            };

            ///////////////////////////////////////////////////////////////////
            return new CommandGroupCollection() {
                rulesInCastleAgeOnly,
                internalAffairsInCastleAge,
                militaryInCastleAge,
                endOfCastlelAge,
                rulesInCastleAgeOrLater,
                rulesToCastlelAgeOnly
            };
        }
    }
}