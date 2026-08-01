using System.Collections.Generic;
using Scripts.Config;
using UnityEngine;

namespace Assets.Scripts.Mastery
{
	public class MasterTableView : MonoBehaviour
	{
		public UIScrollView ScrollView;

		public UITable table;

		public UILabel lb_totalLevel;

		private List<MasteryItemView> masteryItemViews;

		private MainCharacterData mainCharacterData;

		private bool allowEdit;

		private void Awake()
		{
		}

		public void Show(MainCharacterData mainCharacterData, bool allowEdit)
		{
		}

		public void EnableBoxItems(bool enable)
		{
		}

		public void Hide()
		{
		}

		public void UpdateData()
		{
		}

		private void InitItem()
		{
		}

		private void SelectMastery(MasteryInfo masteryInfo)
		{
		}
	}
}
