using System.Collections.Generic;

public abstract class ITutorialGroup
{
	private TutorialStage curStage;

	protected List<TutorialStage> totalStage;

	private string name;

	protected MainCharacterData MainCharacterData;

	public Dictionary<TutorialKey, List<TutorialStage>> TutorialStage;

	public virtual bool IsComplete => false;

	public ITutorialGroup(string name, MainCharacterData mainCharacterData)
	{
	}

	public TutorialStage AddStage(TutorialStage stage)
	{
		return null;
	}

	public void Active(TutorialKey key)
	{
	}

	public bool CanActiveKey(TutorialKey key)
	{
		return false;
	}

	public bool HasCompleteStageWithKey(TutorialKey key)
	{
		return false;
	}

	public void Resset()
	{
	}

	public void NextStageDelegate(TutorialKey key, TutorialStage stage)
	{
	}

	public void SkipDialog(TutorialKey key)
	{
	}

	public void EmptyDelegate(TutorialKey key, TutorialStage stage)
	{
	}

	public void SendMetricTutorial(TutorialKey key, TutorialStage stage)
	{
	}

	public void NextStage(TutorialKey key, TutorialStage curStage)
	{
	}

	private bool CheckPreStageComplte(TutorialStage stage)
	{
		return false;
	}

	public virtual bool Condition(TutorialKey fromKey)
	{
		return false;
	}

	public virtual bool IsErrorData()
	{
		return false;
	}

	protected float GetDelayDialog()
	{
		return 0f;
	}

	public List<TutorialStage> AddDialog(TutorialKey key, List<DialogTutParameter> parameters, bool require = true)
	{
		return null;
	}

	public virtual bool IsCanInterrupt()
	{
		return false;
	}

	protected void Complete()
	{
	}

	protected void Complete(TutorialKey key, TutorialStage stage)
	{
	}

	public virtual bool IsAlwayCheckError()
	{
		return false;
	}
}
