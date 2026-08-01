using System;
using System.Collections.Generic;
using Assets.Scripts.Ssar.Dungeon;
using SSAR.Dungeon.Model;
using Scripts.Config;
using Ssar.Dungeon.Model;
using Ssar.RaidBoss.Model;
using UnityEngine;

public class DungeonDataManager
{
	private DungeonPlayTime dungeonPlayTime;

	private DungeonDamageTaken dungeonDamageTaken;

	private DungeonItemUsed dungeonItemUsed;

	private DungeonUsedSkill dungeonUsedSkill;

	private DungeonObjectiveManager dungeonObjectiveManager;

	private DungeonMonsterKilledManager dungeonMonsterKilledManager;

	private float mainMaxHp;

	private float bonusExpGained;

	private float bonusSoulGained;

	private int resurrectionRemaining;

	private Action<float> onUpdate;

	private List<ItemInfo> ListReward;

	private Dictionary<BoostItemType, bool> dictUseBoostItem;

	private bool isDelayShowWinUIUntilRelease;

	private bool isDelayReEnableInputWhenWin;

	private Vector3 deathPositionOfBoss;

	private bool isDungeonEnd;

	private Vector3 deathPositionOfLastMonster;

	private bool isTestMode;

	private int curStage;

	private int curWave;

	private bool enableSlowMotionWhenWin;

	private MainCharacterData mainCharacterData;

	private bool isDoubleExp;

	public string DieReason { get; set; }

	public Vector3 DeathPositionOfBoss
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 DeathPositionOfLastMonster
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public void DungeonSkillUsed()
	{
	}

	public bool CheckDungeonSkillUsed()
	{
		return false;
	}

	public void SetMaxHp(float maxHp)
	{
	}

	public float GetMaxHp()
	{
		return 0f;
	}

	public void ResurrectionSuccess()
	{
	}

	public bool CanResurrection()
	{
		return false;
	}

	public void AddBonusExpGained(float bonusExpGained)
	{
	}

	public void SetDoubleExp()
	{
	}

	public void AddBonusSoulGained(float bonusSoulGained)
	{
	}

	public void AddReward(ItemInfo itemInfo)
	{
	}

	public List<ItemInfo> GetRewards()
	{
		return null;
	}

	public void Update(float deltaTime)
	{
	}

	public int GetTimePlayed()
	{
		return 0;
	}

	public DungeonPlayTime DungeonPlayTime()
	{
		return null;
	}

	public int GetDamageTaken()
	{
		return 0;
	}

	public int GetNumOfHpPotionUsed()
	{
		return 0;
	}

	public void UseHpPotion()
	{
	}

	public string GetDisplayName()
	{
		return null;
	}

	public void ListenOnUpdate(Action<float> action)
	{
	}

	public void RemveListenOnUpdate(Action<float> action)
	{
	}

	public DungeonDamageTaken GetDungeonDamageTakenData()
	{
		return null;
	}

	public DungeonObjectiveManager GetDungeonObjectiveManager()
	{
		return null;
	}

	public DungeonMonsterKilledManager GetDungeonMonsterKilledManager()
	{
		return null;
	}

	public bool IsUsedBoostItem(BoostItemType type)
	{
		return false;
	}

	public void SetUseBoostItem(BoostItemType BoostItemType, bool isUse)
	{
	}

	private int GetNode()
	{
		return 0;
	}

	public bool IsDelayShowUIWinUntilRelease()
	{
		return false;
	}

	public void SetDelayShowUIWinUntilRelease(bool isDelayShowWinUIUntilRelease)
	{
	}

	public bool IsDelayReEnableInputWhenWill()
	{
		return false;
	}

	public void SetDelayReEnableInputWhenWill(bool isDelayReEnableInputWhenWill)
	{
	}

	public void SetTestMode()
	{
	}

	public bool IsTestMode()
	{
		return false;
	}

	public void SetDungeonEnd()
	{
	}

	public bool IsDungeonEnd()
	{
		return false;
	}

	public void SetCurrentStage(int stageOrder)
	{
	}

	public int GetCurrentStage()
	{
		return 0;
	}

	public void SetCurrentWave(int wave)
	{
	}

	public int GetCurrentWave()
	{
		return 0;
	}

	public DungeonWinParameter GenerateWinParameter()
	{
		return null;
	}

	public DungeonWinParameter GenerateBloodyWinParameter(BloodyTowerFloorInfo floorInfo, List<ItemInfo> rewardInfos)
	{
		return null;
	}

	public int GetBloodyTowerWinStar()
	{
		return 0;
	}

	public void GetBloodyTowerStarRule(out IDungeonGetStarRule star1, out IDungeonGetStarRule star2, out IDungeonGetStarRule star3)
	{
		star1 = null;
		star2 = null;
		star3 = null;
	}

	public static IDungeonGetStarRule[] GetStarPreviewInScene()
	{
		return null;
	}

	public RaidWinParameter GenerateRaidWinParameter(RaidBossConfig.Room roomInfo, List<RaidWinRankInfo> rankInfos, List<ItemInfo> rewards)
	{
		return null;
	}

	public bool IsEnableSlowMotionWhenWin()
	{
		return false;
	}

	public void DisableSlowMotionWhenWin()
	{
	}

	private int GetStar()
	{
		return 0;
	}

	private void CalculateExp(out int baseExp, out int bonusExp)
	{
		baseExp = default(int);
		bonusExp = default(int);
	}

	private void CalculateSoul(out int baseSoul, out int bonusSoul)
	{
		baseSoul = default(int);
		bonusSoul = default(int);
	}

	private int CalculateDungeonTimePlayToPoint()
	{
		return 0;
	}

	private int CalculateDungeonDamageTakenToPoint()
	{
		return 0;
	}

	private int CalculateDungeonItemUsedToPoint()
	{
		return 0;
	}

	private DungeonConfig GetDungeonConfig()
	{
		return null;
	}

	private Scripts.Config.Dungeon GetDungeon()
	{
		return null;
	}

	private int DungeonMaxMonster()
	{
		return 0;
	}

	private MemoryShardInfo GetShardDrop()
	{
		return null;
	}
}
