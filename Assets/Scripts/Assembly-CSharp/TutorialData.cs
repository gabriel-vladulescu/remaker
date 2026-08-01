using System;
using System.Collections.Generic;

[Serializable]
public class TutorialData
{
	public List<int> listIdsComplete;

	public List<int> listIdsReceivePrepareData;

	public void AddTutorialComplete(int tutorialId)
	{
	}

	public List<int> GetListTutorialComplete()
	{
		return null;
	}

	public void AddListTutorialComplete(List<int> tutorialIds)
	{
	}

	public bool HasReceivePrepareData(int tutorialGroup)
	{
		return false;
	}

	public void ReceivePrepareData(int tutorialGroup)
	{
	}

	public bool HasCompletetTutorial(int tutorialGroup)
	{
		return false;
	}
}
