using Artemis;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class AttackOverrideModifier : AttackModifier
	{
		private float attackBonus;

		public AttackOverrideModifier(AttackInfo info, Entity target)
			: base(null, null)
		{
		}

		public override string Name()
		{
			return null;
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
