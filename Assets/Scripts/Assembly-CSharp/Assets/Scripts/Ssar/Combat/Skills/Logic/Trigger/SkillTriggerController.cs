using System;
using System.Collections.Generic;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Projectiles;

namespace Assets.Scripts.Ssar.Combat.Skills.Logic.Trigger
{
	public class SkillTriggerController
	{
		private SkillData skillData;

		private Dictionary<TriggerType, Dictionary<EventFrame, List<ModifierConfig>>> triggerMapping;

		private Action<List<SkillTriggerData>> callback;

		private readonly HashSet<TriggerType> VALID_TRIGGER_TYPES;

		public SkillTriggerController(SkillData skillData, Action<List<SkillTriggerData>> callback)
		{
		}

		public void OnAddEventFrame(EventFrame eventFrame)
		{
		}

		private void AddModifierConfig(ModifierConfig modifierConfig, EventFrame eventFrame)
		{
		}

		public void OnTrigger(TriggerType triggerType, EventFrame eventFrame, Projectile sourceProjectile, List<ModifierType> filteredModifierTypes = null, List<ModifierType> ignoredModifierTypes = null)
		{
		}
	}
}
