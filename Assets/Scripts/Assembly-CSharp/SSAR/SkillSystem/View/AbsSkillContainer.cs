using System.Collections.Generic;
using Scripts.Config;
using UnityEngine;

namespace SSAR.SkillSystem.View
{
	public abstract class AbsSkillContainer : MonoBehaviour
	{
		public AbsSkillRowView row_1;

		public AbsSkillRowView row_2;

		public AbsSkillRowView row_3;

		public UILabel lb_current;

		public UILabel lb_next;

		private int curSkillId;

		private MainCharacterData mainCharacterData;

		private bool allowEdit;

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		public void Show(MainCharacterData mainCharacterData, bool allowEdit, Preset Preset)
		{
		}

		public void Hide()
		{
		}

		private void Select(int skillId, Preset preset)
		{
		}

		private void ShowValue(Preset preset)
		{
		}

		protected abstract void OnShow(MainCharacterData mainCharacterData);

		protected abstract List<ISkillStat> Row1SkillList(MainCharacterData mainCharacterData);

		protected abstract List<ISkillStat> Row2SkillList(MainCharacterData mainCharacterData);

		protected abstract List<ISkillStat> Row3SkillList(MainCharacterData mainCharacterData);

		protected abstract ISkillStat GetCurrentSkillStat(MainCharacterData mainCharacterData, int curSkillId);

		protected abstract int GetCurrentLevel(MainCharacterData mainCharacterData, ISkillStat skillStat, Preset preset);

		protected abstract bool IsMaxLevel(ISkillStat skillStat, int level);

		protected abstract string GetDescription(ISkillStat skillStat);

		protected abstract double GetValueInVisual(ISkillStat skillStat, int level);
	}
}
