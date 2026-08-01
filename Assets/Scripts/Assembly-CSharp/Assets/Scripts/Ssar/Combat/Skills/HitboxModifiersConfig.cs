using System;
using System.Collections.Generic;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class HitboxModifiersConfig
	{
		public bool expanded;

		public bool allyExpanded;

		public List<ModifierConfig> modifierConfigs;

		public List<ModifierConfig> allyModifierConfigs;

		public void OnAfterDeserialize(SkillEventFrameConfig config)
		{
		}
	}
}
