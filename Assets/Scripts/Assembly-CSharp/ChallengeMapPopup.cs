using SSAR.View;
using Ssar.DailyChallenge.View;
using Ssar.RaidBoss.View;
using UnityEngine;

public class ChallengeMapPopup : BasePopup
{
	public GameObject resourcesContainer;

	public GameObject btn_equipment;

	public GameObject btn_skill;

	public GameObject btn_chest;

	public GameObject btn_mastery;

	public ChallengeMapButton buttonBloodyTower;

	public ChallengeMapButtonArena buttonArena;

	public ChallengeMapButtonRaidBoss ButtonRaid;

	public ChallengeMapButtonDailyChallenge buttonDailyChallenge;

	protected override void Awake()
	{
	}

	private void OpenMastery(GameObject go)
	{
	}

	protected override void onEnable()
	{
	}

	protected override bool EnableBack()
	{
		return false;
	}

	public void Show()
	{
	}

	private void InitResources()
	{
	}

	private void OpenSkillManager(GameObject o)
	{
	}

	private void OpenChest(GameObject o)
	{
	}

	private void OpenEquipment(GameObject o)
	{
	}

	private void CheckUnlockMastery()
	{
	}
}
