using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Ssar.AnniversaryEvent
{
	public class FirstAnniversaryQuestRewardContainer : MonoBehaviour
	{
		public GameObject table;

		public UILabel lb_desc;

		public GameObject btn_desc;

		public GameObject btn_claim;

		public UILabel lb_nextDay;

		public UISprite sp_arrow;

		private float delta;

		private List<RewardReceiveView> rewardReceiveViews;

		private List<UILabel> labels;

		private QuestInfo questInfo;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void ClaimReward(GameObject o)
		{
		}

		public void UpdateData(FirstAnniversaryQuestData firstAnniversaryQuestData)
		{
		}

		private void UpdateDesc(FirstAnniversaryQuestData data)
		{
		}

		private List<QuestInfo> pickQuestInfos(int currentQuestId)
		{
			return null;
		}

		private QuestInfo CurrentQuest(int currentQuestId)
		{
			return null;
		}

		private void Init()
		{
		}

		private MainCharacterData Data()
		{
			return null;
		}
	}
}
