using System;
using System.Collections.Generic;
using Scripts.Config;
using UnityEngine;

namespace SSAR.SkillSystem.View
{
	public abstract class AbsSkillRowView : MonoBehaviour
	{
		public GameObject[] table;

		private List<AbsSkillView> signatureSkillViews;

		public Action<int, Preset> OnSelect;

		private Preset preset;

		private void Awake()
		{
		}

		public void Init<T>() where T : SignatureSkillView
		{
		}

		public void Show(MainCharacterData mainCharacterData, List<ISkillStat> signatureSkillStats, int curSkillSelected, bool allowEdit, Preset preset)
		{
		}

		private static GameObject MapClassValue<T>(GameObject item) where T : AbsSkillView
		{
			return null;
		}

		private void Select(int skillId)
		{
		}

		protected abstract Type GetSkillViewType();
	}
}
