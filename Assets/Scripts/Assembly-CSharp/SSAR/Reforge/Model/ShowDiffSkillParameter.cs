using SSAR.Equipment.Model;

namespace Ssar.Reforge.Model
{
	public class ShowDiffSkillParameter
	{
		public string skillId;

		public int lv;

		public EquipmentSkillType skillType;

		public float comparerDiff;

		public ShowDiffSkillParameter(EquipmentSkillType skillType, string skillId, int lv, float comparerDiff = 0f)
		{
		}
	}
}
