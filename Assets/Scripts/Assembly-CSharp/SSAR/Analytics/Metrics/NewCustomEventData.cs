using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Scripts.Config;

namespace Ssar.Analytics.Metrics
{
	public class NewCustomEventData : CustomEventData
	{
		public NewCustomEventData(CharacterName characterName)
			: base(default(CharacterName))
		{
		}

		public NewCustomEventData()
			: base(default(CharacterName))
		{
		}

		public override CustomEventData AddHeroName(string name)
		{
			return null;
		}

		public void AddLevel(int level)
		{
		}

		public void AddNode(string name)
		{
		}

		public void AddMatchName(string name)
		{
		}

		public void AddNewPlayingTime(int playingTime)
		{
		}

		public void AddHighestNode(string nodeValue)
		{
		}

		public override CustomEventData AddCurrentGold(int currentGold)
		{
			return null;
		}

		public override CustomEventData AddCurrentCrystal(int currentCrystal)
		{
			return null;
		}

		public override CustomEventData AddRealMoneySpent(float value)
		{
			return null;
		}

		public void AddPlayingTime(int playingTime)
		{
		}

		public void AddEventId(int eventId)
		{
		}

		public void AddDailyCount(int count)
		{
		}

		public void AddNameReward(string nameReward)
		{
		}

		public override CustomEventData AddAncientEnhanceLevel(int value)
		{
			return null;
		}

		public override CustomEventData AddVisualName(string visualName, int index)
		{
			return null;
		}

		public override CustomEventData AddSkillId(int skillId, int index)
		{
			return null;
		}

		public override CustomEventData AddSkillPoint(int skillPoint)
		{
			return null;
		}

		public override CustomEventData AddSkillIdRuneId(string skillIdRuneId)
		{
			return null;
		}

		public override CustomEventData AddPurchasedSkillPoint(int skillPoint)
		{
			return null;
		}

		public override CustomEventData AddMasteryName(string value)
		{
			return null;
		}

		public override CustomEventData AddMasterySubLevel(int value)
		{
			return null;
		}

		public override CustomEventData AddMasteryTotalLevel(int value)
		{
			return null;
		}

		public override CustomEventData AddArenaSeasonalCode(int value)
		{
			return null;
		}

		public override CustomEventData AddOreRuneName(string name)
		{
			return null;
		}

		public override CustomEventData AddItemType(string type)
		{
			return null;
		}

		public override CustomEventData AddPetName(string name)
		{
			return null;
		}

		public override CustomEventData AddCurrentEnhanceLevel(int level)
		{
			return null;
		}

		public override CustomEventData AddCharacterPower(int value)
		{
			return null;
		}

		public override CustomEventData AddBossPower(int value)
		{
			return null;
		}

		public override CustomEventData AddGoodName(string name)
		{
			return null;
		}

		public override CustomEventData AddHpPotionUsageCount(int count)
		{
			return null;
		}

		public void AddTowerNode(string node)
		{
		}

		public void AddTowerHighestNode(string highestNode)
		{
		}

		public void AddRaidRank(string rank)
		{
		}

		public void AddResult(string result)
		{
		}

		public void AddWinResult()
		{
		}

		public void AddLoseResult()
		{
		}

		public void AddMatchTime(int time)
		{
		}

		public void AddLoseReason(string reason)
		{
		}

		public void AddItemName(string name)
		{
		}

		public void AddItemId(string id)
		{
		}

		public void AddValue(int value)
		{
		}

		public void AddType(string type)
		{
		}

		public void AddName(string name)
		{
		}

		public void AddId(int id)
		{
		}

		public void AddItemViewCount(int count)
		{
		}

		public void AddCurrencyType(string type)
		{
		}

		public void AddSoulType()
		{
		}

		public void AddCrystalType()
		{
		}

		public void AddAttack(int attack)
		{
		}

		public void AddDef(int def)
		{
		}

		public void AddHp(int hp)
		{
		}

		public void AddPower(int power)
		{
		}

		public void AddRivalCharacterPower(int power)
		{
		}

		public void AddArena(string arena)
		{
		}

		public void AddBlood(double blood)
		{
		}

		public void ClickToFeatureInMainSence(int count)
		{
		}

		public void ClickToCategory(int count)
		{
		}

		public void AddStar(int star)
		{
		}

		public void AddTryCount(int tryCount)
		{
		}

		public void AddDieReason(string reason)
		{
		}

		public void AddSetNameTime(int duration)
		{
		}

		public void AddMatchTimeUntilDie(int duration)
		{
		}

		public void AddDungeonMode()
		{
		}

		public void AddTowerMode()
		{
		}

		public void AddMatchMode(string mode)
		{
		}

		public void AddMatchMode(BattleMode battleMode)
		{
		}

		public void AddPreviousScreenTime(float duration)
		{
		}

		public void AddPreviousLocation(string previousLocation)
		{
		}

		public void AddLocation(string location)
		{
		}

		public void AddAdsLocation(string source)
		{
		}

		public void AddItemCategory(string itemCategory)
		{
		}

		public void AddMoney(double money)
		{
		}

		public void AddPurchasedCount(int purchasedCount)
		{
		}

		public void AddItemPurchasedCount(int itemPurchasedCount)
		{
		}

		public void AddFpsMin(float fpsMin)
		{
		}

		public void AddFpsMax(float fpsMax)
		{
		}

		public void AddFpsBelow10(int fpsBelow10)
		{
		}

		public void AddFpsBelow20(int fpsBelow20)
		{
		}

		public void AddWeapon(string weapon)
		{
		}

		public void AddArmor(string armor)
		{
		}

		public void AddAccessory(string accessory)
		{
		}

		public void AddCostume(string costume)
		{
		}

		public void AddAncient(string ancient)
		{
		}

		public void AddCurrentCoins(int currentCoin)
		{
		}

		public void AddTotalFreeCoins(int totalCoin)
		{
		}

		public void AddTotalExchangeTimes(int totalExchangeTime)
		{
		}

		public void AddDaily(int dailyCount)
		{
		}

		public void AddCoinsValue(int coinValue)
		{
		}

		public void AddTotalQuest(int totalQuest)
		{
		}

		public void AddTotalDailyQuest(int totalDailyQuest)
		{
		}

		public void AddGiftId(int giftId)
		{
		}

		public void AddExchangeTimes(int exchangeTime)
		{
		}

		public void AddTotalGiftId(string totalGiftId)
		{
		}

		public void AddPreviousEarnCoins(int previousEarnCoins)
		{
		}

		public void AddPreviousSpendCoins(int previousSpendCoins)
		{
		}

		public void AddPreviousExchangeTimes(int previousExchangeTimes)
		{
		}

		public void AddExchangeValue(int value)
		{
		}
	}
}
