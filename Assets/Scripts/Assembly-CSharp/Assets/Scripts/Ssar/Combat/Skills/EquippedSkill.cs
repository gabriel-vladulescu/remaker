using Assets.Scripts.Ssar.Combat.HeroStateMachines.States;

namespace Assets.Scripts.Ssar.Combat.Skills
{
	public class EquippedSkill
	{
		private string skillId;

		private ComboAttackState.IgnoreInputWindow ignoreInputWindow;

		private ComboAttackState.AnimationFrame animationFrame;

		private readonly SkillConfig sc;

		public string SkillId => null;

		public ComboAttackState.IgnoreInputWindow IgnoreInputWindow => null;

		public ComboAttackState.AnimationFrame AnimationFrame => null;

		public SkillConfig SkillConfig => null;

		public EquippedSkill(string skillId, ComboAttackState.IgnoreInputWindow ignoreInputWindow, ComboAttackState.AnimationFrame animationFrame, SkillConfig sc)
		{
		}
	}
}
