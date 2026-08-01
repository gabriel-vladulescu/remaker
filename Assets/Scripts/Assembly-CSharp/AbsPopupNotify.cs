using System;

public abstract class AbsPopupNotify
{
	public abstract void Process(Action onContinue, Action onBreak);

	public abstract bool IsNotify(string sceneName);

	public abstract string[] SceneActive();

	public void Show()
	{
	}

	protected abstract void OnShow();

	public virtual bool IsByPassCheckTutorial()
	{
		return false;
	}
}
