using Artemis;
using Assets.Scripts.Core.Skills.Modifiers;
using Assets.Scripts.Ssar.Combat.Skills;

namespace SSAR.BattleSystem.AI
{
	public class AIDamageBuff : AbsAIBuff
	{
		private class AIDamageModifier : AttackModifier
		{
			private bool isFinish;

			private Entity target;

			public AIDamageModifier(AttackInfo info, Entity target)
				: base(null, null)
			{
			}

			public void ForceExit()
			{
			}

			protected override bool IsModifierFinish()
			{
				return false;
			}
		}

		private SkillComponent skillComponent;

		private AIDamageModifier attackModifier;

		public AIDamageBuff(Entity self, AIBuffConfig config)
			: base(null, null)
		{
		}

		protected override void OnEnter()
		{
		}

		protected override void OnUpdate(float deltaTime)
		{
		}

		protected override void OnExit()
		{
		}

		private float Duration()
		{
			return 0f;
		}
	}
}
