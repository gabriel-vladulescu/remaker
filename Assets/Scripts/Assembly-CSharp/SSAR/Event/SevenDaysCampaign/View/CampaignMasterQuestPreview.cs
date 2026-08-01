using System.Collections.Generic;
using Scripts.Config;
using UnityEngine;

namespace Ssar.Event.SevenDaysCampaign.View
{
	public class CampaignMasterQuestPreview : MonoBehaviour
	{
		public enum Mode
		{
			Preview = 0,
			Selector = 1
		}

		public UILabel lbName;

		public UILabel lbProgress;

		public UIProgressBar progressBar;

		public GameObject btnChoose;

		public GameObject notiObj;

		public GameObject receivedObj;

		public GameObject modelRoot;

		public CampaignMasterRewardSelector rewardSelector;

		public float refreshInterval;

		private List<CampaignConfig.CampaignQuestItem> questItems;

		private PetGenerationConfig petGenerationConfig;

		private PetVisualConfig petVisualConfig;

		private RandomPetConfig randomPetConfig;

		private GameObject petModel;

		private CampaignConfig.CampaignQuestItem currentQuestItem;

		private int questIndex;

		private float interval;

		private Mode mode;

		public Mode CurrentMode => default(Mode);

		private void Awake()
		{
		}

		private void Choose(GameObject go)
		{
		}

		private void ChangeQuestIndex()
		{
		}

		private void ShowQuest()
		{
		}

		private void OnLoadPetSuccess(GameObject obj)
		{
		}

		private void Update()
		{
		}

		internal void Show()
		{
		}

		internal void Refresh()
		{
		}

		internal void Hide()
		{
		}

		internal void BackToPreview()
		{
		}
	}
}
