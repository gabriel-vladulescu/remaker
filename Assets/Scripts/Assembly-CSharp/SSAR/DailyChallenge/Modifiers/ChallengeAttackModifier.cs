using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Modifiers;

namespace Ssar.DailyChallenge.Modifiers
{
	public class ChallengeAttackModifier : AttackModifier
	{
		public ChallengeAttackModifier(AttackInfo info, Entity target)
			: base(null, null)
		{
		}

		public override ModifierType Type()
		{
			return default(ModifierType);
		}

		public override void OnBeReplaced(Character character)
		{
		}

		public override void OnAttach(Character character)
		{
		}

		public override void OnDetach(Character character)
		{
		}
	}
}
