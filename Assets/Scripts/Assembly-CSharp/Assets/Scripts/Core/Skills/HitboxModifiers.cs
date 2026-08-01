using System.Collections.Generic;
using Assets.Scripts.Ssar.Combat.Skills;

namespace Assets.Scripts.Core.Skills
{
	public class HitboxModifiers
	{
		private List<ModifierConfig> modifierConfigs;

		private List<ModifierConfig> allyModifierConfigs;

		public List<ModifierConfig> ModifierConfigs => null;

		public List<ModifierConfig> AllyModifierConfigs => null;

		public HitboxModifiers(List<ModifierConfig> modifierConfigs, List<ModifierConfig> allyModifierConfigs)
		{
		}
	}
}
