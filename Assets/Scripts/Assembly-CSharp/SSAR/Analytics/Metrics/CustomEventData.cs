using System.Collections;
using System.Collections.Generic;
using Scripts.Config;

namespace Ssar.Analytics.Metrics
{
	public class CustomEventData : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable
	{
		private Dictionary<string, object> data;

		public Dictionary<string, object> Data => null;

		public int Count
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public bool IsReadOnly { get; private set; }

		public object this[string key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ICollection<string> Keys { get; private set; }

		public ICollection<object> Values { get; private set; }

		public CustomEventData(CharacterName characterName)
		{
		}

		public CustomEventData()
		{
		}

		public string Json()
		{
			return null;
		}

		public CustomEventData AddCharacterId(string characterId)
		{
			return null;
		}

		public virtual CustomEventData AddLevel(string level)
		{
			return null;
		}

		public string ShowLevel()
		{
			return null;
		}

		public virtual CustomEventData AddPlayingTime(float playingTime)
		{
			return null;
		}

		public bool RemovePlayingTime()
		{
			return false;
		}

		public CustomEventData AddEnterMainSceneLoadingTime(float loadingTime)
		{
			return null;
		}

		public CustomEventData AddEnterWorldMapLoadingTime(float loadingTime)
		{
			return null;
		}

		public CustomEventData AddEnterDungeonModeLoadingTime(float loadingTime)
		{
			return null;
		}

		public CustomEventData AddNodeId(string nodeId)
		{
			return null;
		}

		public CustomEventData AddNodeValue(string nodeValue)
		{
			return null;
		}

		public string ShowNodeId()
		{
			return null;
		}

		public virtual CustomEventData AddCurrentGold(int currentGold)
		{
			return null;
		}

		public CustomEventData AddCurrentExp(int currentExp)
		{
			return null;
		}

		public virtual CustomEventData AddCurrentCrystal(int currentCrystal)
		{
			return null;
		}

		public CustomEventData AddCurrentVideoPoint(int currentVideoPoint)
		{
			return null;
		}

		public CustomEventData AddWeaponRarity(string weaponRarity)
		{
			return null;
		}

		public CustomEventData AddWeaponTier(int weaponTier)
		{
			return null;
		}

		public CustomEventData AddWeaponEnhanceLevel(int weaponEnhanceLevel)
		{
			return null;
		}

		public CustomEventData AddHelmetRarity(string rarity)
		{
			return null;
		}

		public CustomEventData AddHelmetTier(int helmetTier)
		{
			return null;
		}

		public CustomEventData AddHelmetEnhanceLevel(int helmetEnhanceLevel)
		{
			return null;
		}

		public CustomEventData AddChestRarity(string rarity)
		{
			return null;
		}

		public CustomEventData AddChestTier(int chestTier)
		{
			return null;
		}

		public CustomEventData AddChestEnhanceLevel(int chestEnhanceLevel)
		{
			return null;
		}

		public CustomEventData AddPantRarity(string rarity)
		{
			return null;
		}

		public CustomEventData AddPantTier(int pantTier)
		{
			return null;
		}

		public CustomEventData AddPantEnhanceLevel(int pantEnhanceLevel)
		{
			return null;
		}

		public CustomEventData AddAmuletRarity(string rarity)
		{
			return null;
		}

		public CustomEventData AddAmuletTier(int amuletTier)
		{
			return null;
		}

		public CustomEventData AddAmuletEnhanceLevel(int amuletEnhanceLevel)
		{
			return null;
		}

		public CustomEventData AddRingRarity(string rarity)
		{
			return null;
		}

		public CustomEventData AddRingTier(int ringTier)
		{
			return null;
		}

		public CustomEventData AddRingEnhanceLevel(int ringEnhanceLevel)
		{
			return null;
		}

		public CustomEventData AddUseExpBooster(bool useExpBooster)
		{
			return null;
		}

		public CustomEventData AddUseSoulBooster(bool useSoulBooster)
		{
			return null;
		}

		public CustomEventData AddUseHpPotion(bool useHpPotion)
		{
			return null;
		}

		public virtual CustomEventData AddHpPotionUsageCount(int count)
		{
			return null;
		}

		public CustomEventData AddCurrentHp(int hp)
		{
			return null;
		}

		public CustomEventData AddMaxHp(int maxHp)
		{
			return null;
		}

		public CustomEventData AddHpRatio(float ratio)
		{
			return null;
		}

		public CustomEventData AddLosingReason(string reason)
		{
			return null;
		}

		public CustomEventData AddGainedExp(int exp)
		{
			return null;
		}

		public void AddSourceUpLevel(string source)
		{
		}

		public CustomEventData AddGainedSould(int soul)
		{
			return null;
		}

		public CustomEventData AddGainedItemCount(string count)
		{
			return null;
		}

		public CustomEventData AddGainedItemRarity(string rarity)
		{
			return null;
		}

		public CustomEventData AddCurrentPlayingTime(float time)
		{
			return null;
		}

		public virtual CustomEventData AddHighestNodeId(string nodeId)
		{
			return null;
		}

		public virtual CustomEventData AddHighestNodeValue(string nodeValue)
		{
			return null;
		}

		public CustomEventData AddHighestRankId(string id)
		{
			return null;
		}

		public virtual CustomEventData AddSkillPoint(int skillPoint)
		{
			return null;
		}

		public virtual CustomEventData AddPurchasedSkillPoint(int skillPoint)
		{
			return null;
		}

		public CustomEventData AddSkillId(string skillId)
		{
			return null;
		}

		public CustomEventData AddRuneId(string runeId)
		{
			return null;
		}

		public virtual CustomEventData AddSkillIdRuneId(string skillIdRuneId)
		{
			return null;
		}

		public CustomEventData AddQuantity(int quantity)
		{
			return null;
		}

		public virtual CustomEventData AddItemType(string type)
		{
			return null;
		}

		public CustomEventData AddRarity(string rarity)
		{
			return null;
		}

		public CustomEventData AddTier(int tier)
		{
			return null;
		}

		public virtual CustomEventData AddCurrentEnhanceLevel(int level)
		{
			return null;
		}

		public CustomEventData AddCost(float cost)
		{
			return null;
		}

		public CustomEventData AddCurrency(string currency)
		{
			return null;
		}

		public CustomEventData AddAchievementId(string id)
		{
			return null;
		}

		public CustomEventData AddAchievementName(string name)
		{
			return null;
		}

		public virtual CustomEventData AddDailyCount(string count)
		{
			return null;
		}

		public virtual CustomEventData AddEventId(string eventId)
		{
			return null;
		}

		public virtual CustomEventData AddGoodName(string name)
		{
			return null;
		}

		public CustomEventData AddSku(string sku)
		{
			return null;
		}

		public virtual CustomEventData AddRealMoneySpent(float value)
		{
			return null;
		}

		public CustomEventData AddSource(string source)
		{
			return null;
		}

		public CustomEventData AddStepName(string stepName)
		{
			return null;
		}

		public CustomEventData AddStepValue(string stepValue)
		{
			return null;
		}

		public CustomEventData AddHubLevel1Node(string name)
		{
			return null;
		}

		public CustomEventData AddHubLevel2Node(string name)
		{
			return null;
		}

		public CustomEventData AddAction(string action)
		{
			return null;
		}

		public CustomEventData AddDuration(float value)
		{
			return null;
		}

		public virtual CustomEventData AddHeroName(string name)
		{
			return null;
		}

		public string ShowHeroName()
		{
			return null;
		}

		public CustomEventData AddHeroId(string id)
		{
			return null;
		}

		public string ShowHeroId()
		{
			return null;
		}

		public CustomEventData AddVersion(string version)
		{
			return null;
		}

		public CustomEventData AddCrossPromotionName(string name)
		{
			return null;
		}

		public CustomEventData AddCrossPromotionRewardType(string type)
		{
			return null;
		}

		public CustomEventData AddCrossPromotionRewardValue(int value)
		{
			return null;
		}

		public CustomEventData AddCrossPromotionUrl(string url)
		{
			return null;
		}

		public virtual CustomEventData AddMasteryName(string value)
		{
			return null;
		}

		public virtual CustomEventData AddMasterySubLevel(int value)
		{
			return null;
		}

		public virtual CustomEventData AddMasteryTotalLevel(int value)
		{
			return null;
		}

		public virtual CustomEventData AddArenaSeasonalCode(int value)
		{
			return null;
		}

		public CustomEventData AddWinner(string name)
		{
			return null;
		}

		public CustomEventData AddRuneName(string name)
		{
			return null;
		}

		public virtual CustomEventData AddPetName(string name)
		{
			return null;
		}

		public CustomEventData AddPetRarity(string rarity)
		{
			return null;
		}

		public virtual CustomEventData AddOreRuneName(string name)
		{
			return null;
		}

		public CustomEventData AddContinuousDayCount(int value)
		{
			return null;
		}

		public CustomEventData AddRaidSeasonalCode(int value)
		{
			return null;
		}

		public virtual CustomEventData AddCharacterPower(int value)
		{
			return null;
		}

		public virtual CustomEventData AddBossPower(int value)
		{
			return null;
		}

		public CustomEventData AddDifficulty(string value)
		{
			return null;
		}

		public CustomEventData AddMode(string value)
		{
			return null;
		}

		public CustomEventData AddMile(int value)
		{
			return null;
		}

		public CustomEventData AddDayLeft(int value)
		{
			return null;
		}

		public virtual CustomEventData AddVisualName(string visualName, int index)
		{
			return null;
		}

		public virtual CustomEventData AddSkillId(int skillId, int index)
		{
			return null;
		}

		public virtual CustomEventData AddAncientEnhanceLevel(int value)
		{
			return null;
		}

		public CustomEventData AddQuestId(int value)
		{
			return null;
		}

		public CustomEventData AddFailCount(int value)
		{
			return null;
		}

		public CustomEventData AddRewardId(int value)
		{
			return null;
		}

		public CustomEventData AddToken(int value)
		{
			return null;
		}

		public CustomEventData AddBattleCount(int value)
		{
			return null;
		}

		public CustomEventData AddWin(bool value)
		{
			return null;
		}

		public CustomEventData AddRound(int value)
		{
			return null;
		}

		public CustomEventData AddKill(int value)
		{
			return null;
		}

		protected void Add(string key, object value)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
		{
			return null;
		}

		public void Add(KeyValuePair<string, object> item)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(KeyValuePair<string, object> item)
		{
			return false;
		}

		public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
		{
		}

		public bool Remove(KeyValuePair<string, object> item)
		{
			return false;
		}

		public bool ContainsKey(string key)
		{
			return false;
		}

		void IDictionary<string, object>.Add(string key, object value)
		{
		}

		public bool Remove(string key)
		{
			return false;
		}

		public bool TryGetValue(string key, out object value)
		{
			value = null;
			return false;
		}
	}
}
