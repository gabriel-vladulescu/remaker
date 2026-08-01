using System.Collections.Generic;

public class TutorialManager
{
	public static int STEP_SELECT_LEADER;

	public static float DELAY_ENABLE_WITH_DIALOG;

	public static int MAP_1_1_TRIGGER;

	public static int MAP_1_2_TRIGGER;

	public static int MAP_1_3_TRIGGER;

	public static string MASK;

	public static string CLICK;

	private readonly Dictionary<TutorialKey, List<ITutorialGroup>> dic;

	private Dictionary<string, ITutorialGroup> groups;

	private List<int> tutorialSuspend;

	private ITutorialGroup currentTutorial;

	private List<int> tutorialComplete;

	private bool m_Enable;

	private float timeDelayInput;

	public bool Enable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void InitTutorial(MainCharacterData mainCharacterData)
	{
	}

	public void AddTutorialComplete(int stepId)
	{
	}

	public void LoadTutorialProgress(int[] stepsComplete)
	{
	}

	private void Cheat()
	{
	}

	private void ValidateData()
	{
	}

	public List<int> GetListTutorialInvalid()
	{
		return null;
	}

	private void Reset()
	{
	}

	private void AddTutorialGroup(ITutorialGroup group)
	{
	}

	public bool Dispatch(TutorialKey key)
	{
		return false;
	}

	public void SkipDialog(TutorialKey key)
	{
	}

	public bool IsInTutorialWithKey(TutorialKey key)
	{
		return false;
	}

	public bool IsCompleteFirstDungeon()
	{
		return false;
	}

	public bool IsCompleteLearnSkill()
	{
		return false;
	}

	public bool IsCompleteUpgradeEquipment()
	{
		return false;
	}

	public bool IsCompleteLearnMastery()
	{
		return false;
	}

	public bool CheckComplete(int groupID)
	{
		return false;
	}

	private bool IsSuspend(ITutorialGroup group)
	{
		return false;
	}

	public void ClearCurrentTutorial()
	{
	}

	public void SetSuspendTutorial(int tutorialGroupID)
	{
	}

	private bool CompleteTutorial(int groupID)
	{
		return false;
	}

	public bool IsInTutorial()
	{
		return false;
	}

	public ITutorialGroup GetCurrentTutorial()
	{
		return null;
	}

	public int GetCurrentTutorialGroupId()
	{
		return 0;
	}

	public void ForceDelayInput()
	{
	}

	public List<int> GetTotalGroupIds()
	{
		return null;
	}

	public void OnSimTime(uint dt)
	{
	}
}
