using Artemis;
using Assets.Scripts.Core.Skills;
using Assets.Scripts.Core.Skills.Modifiers;

namespace Ssar.DailyChallenge.Modifiers
{
	public class ChallengeDefenseModifier : DefModifier
	{
		public ChallengeDefenseModifier(DefInfo info, Entity target)
			: base(null, null)
		{
		}

		public override ModifierType Type()
		{
			return default(ModifierType);
		}

		protected override bool ShouldPlayVfx()
		{
			return false;
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
