using System.Collections.Generic;
using Ssar.Analytics.Metrics;

namespace Assets.Scripts.Ssar.Equipment
{
	public interface EquipmentDropLogic
	{
		EquipmentConfigId Drop(CharacterId characterId, GradeDropConfig[] grades, RarityDropConfig[] rarities, TypeDropConfig[] types, string visualCategory, List<int> visualIdIgnore);
	}
}
