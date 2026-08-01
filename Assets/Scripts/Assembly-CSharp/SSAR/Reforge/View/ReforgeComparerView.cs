using System;
using SSAR.Entry.Model;
using SSAR.Equipment.Model;
using SSAR.Equipment.View;
using Ssar.Reforge.Model;
using UnityEngine;
using strange.extensions.mediation.impl;

namespace Ssar.Reforge.View
{
	public class ReforgeComparerView : strange.extensions.mediation.impl.View
	{
		public GameObject container;

		public GameObject btnClick;

		private EquipmentInfoContainer equipmentInfoContainer;

		private Action callback;

		private ParticleRunAroundFx particleRunAroundFx;

		private ReforgeSkillDiffView[] skillDiffViews;

		private new void Awake()
		{
		}

		public void Init(Action callback)
		{
		}

		public void Show(EquipmentCollectData equipmentCollectData, ComparerItemResult compareResult, ReforgeSkillComparerResult skillComparerResult, bool isLeft, int boundIndex = -1)
		{
		}

		private void OnClick(GameObject o)
		{
		}

		private void InitSkillDiff()
		{
		}

		private void ShowSkillDiff(ShowDiffSkillParameter[] skillDiffs)
		{
		}
	}
}
