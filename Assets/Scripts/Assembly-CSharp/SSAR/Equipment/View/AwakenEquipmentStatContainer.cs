using System.Collections.Generic;
using Assets.Scripts.Model;
using SSAR.Equipment.Enum;
using SSAR.Equipment.Model;
using strange.extensions.mediation.impl;

namespace SSAR.Equipment.View
{
	public class AwakenEquipmentStatContainer : strange.extensions.mediation.impl.View
	{
		private class StatCompare
		{
			public StatType StatType;

			public float valueBefore;

			public float valueAfter;

			public StatCompare(StatType statType, float valueBefore)
			{
			}
		}

		private IItem equipmentCollectData;

		private UITable table;

		private AwakenStatRowView[] awakenStatRowViews;

		protected override void Awake()
		{
		}

		public void Show(IItem equipmentCollectData)
		{
		}

		public void OnAddMaterial(IItem equipmentCollectData)
		{
		}

		public void OnRemoveMaterial(IItem equipmentCollectData)
		{
		}

		public void UpdateData()
		{
		}

		private void Init()
		{
		}

		private List<StatCompare> Generate(List<EquipmentStat> stats, List<EquipmentStat> raws, float bonusBefore, float bonusAfter)
		{
			return null;
		}
	}
}
