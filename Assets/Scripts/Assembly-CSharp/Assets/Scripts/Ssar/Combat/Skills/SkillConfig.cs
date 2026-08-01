using System;
using System.Collections.Generic;
using Assets.Scripts.Core.Skills;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	[Serializable]
	public class SkillConfig
	{
		public bool foldout;

		public string skillClassName;

		public string skillStatsId;

		public string animationName;

		public float scaleTime;

		public bool useDurationFromAnimation;

		public float duration;

		public float channelingDuration;

		public bool syncChannelingDurationWithDuration;

		public int runIgnoreInputWindowStartFrame;

		public int runIgnoreInputWindowEndFrame;

		public int animationActiveFrame;

		public int animationRecoveryFrame;

		public int animationLengthInFrame;

		public List<EventFrameConfig> eventFrameConfigs;

		public bool eventTriggerConfigAreaExpand;

		public List<ModifierConfig> modifierConfigs;

		public string extras;

		public bool eventFrameAreaExpand;

		public List<bool> foldoutOfTypesOfEventFrame;

		public float Duration => 0f;

		public float ChannelingDuration => 0f;

		public int RunIgnoreInputWindowStartFrame => 0;

		public int RunIgnoreInputWindowEndFrame => 0;

		public int AnimationActiveFrame => 0;

		public int AnimationRecoveryFrame => 0;

		public int AnimationLengthInFrame => 0;

		public List<EventFrameConfig> FindAllEventFrameConfigsOf(EventType eventType)
		{
			return null;
		}

		public List<ModifierConfig> FindAllModifierConfigOf(TriggerType triggerType, ModifierType modifierType)
		{
			return null;
		}

		public void OnAfterDeserialize(SkillEventFrameConfig config)
		{
		}
	}
}
