using System.Collections.Generic;
using SSAR.Equipment.Model;
using Scripts.Config;
using strange.extensions.mediation.impl;

namespace Ssar.Ancient.View
{
	public class AncientEnhanceStatContainer : strange.extensions.mediation.impl.View
	{
		private class StatContainer
		{
			public SkillExtraStatType type;

			public double statBefore;

			public double statAfter;

			public bool isUp;

			public StatContainer(SkillExtraStatType type, double statBefore, double statAfter, bool isUp)
			{
			}
		}

		public AncientEnhanceStatRow[] statRows;

		private EquipmentCollectData equipmentCollectData;

		internal void Show(EquipmentCollectData equipmentCollectData)
		{
		}

		internal void OnAddMaterial(EquipmentCollectData equipmentCollectData)
		{
		}

		internal void OnRemoveMaterial(EquipmentCollectData equipmentCollectData)
		{
		}

		private void UpdateData()
		{
		}

		private List<StatContainer> GetStatContainers(AncientActiveSkillStat stat, int curEnhancedLv, int nextEnhancedLv)
		{
			return null;
		}
	}
}
