using System;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Modifiers;

namespace SSAR.BattleSystem.Message
{
	public class DungeonObserverManager
	{
		private Action<int, string> onCastSkillEvent;

		private Action<int, string, Skill> onCastSkillEvent2;

		private Action<int, string> onSkillChannelingFinishListener;

		private Action<int, Modifier> onAttachModifeir;

		public void ListenOnCastSkill(Action<int, string> action)
		{
		}

		public void UnListenOnCastSkill(Action<int, string> action)
		{
		}

		public void NotifyCastSkill(int entityId, string skillId)
		{
		}

		public void ListenOnCastSkill(Action<int, string, Skill> action)
		{
		}

		public void UnListenOnCastSkill(Action<int, string, Skill> action)
		{
		}

		public void NotifyCastSkill(int entityId, string skillId, Skill skill)
		{
		}

		public void ListenToSkillChannelingFinish(Action<int, string> listener)
		{
		}

		public void UnlistenToSkillChannelingFinish(Action<int, string> listener)
		{
		}

		public void NotifySkillChannelingFinish(int entityId, string skillId)
		{
		}

		public void ListenOnAttachModifier(Action<int, Modifier> onAttachModifier)
		{
		}

		public void UnListenOnAttachModifier(Action<int, Modifier> onAttachModifier)
		{
		}

		public void NotifyOnAttachModifier(int entityId, Modifier modifier)
		{
		}
	}
}
