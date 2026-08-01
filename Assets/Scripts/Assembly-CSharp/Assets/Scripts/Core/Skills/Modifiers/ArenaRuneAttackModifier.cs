using Artemis;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class ArenaRuneAttackModifier : AttackModifier
	{
		public ArenaRuneAttackModifier(AttackInfo info, Entity target)
			: base(null, null)
		{
		}

		public override ModifierType Type()
		{
			return default(ModifierType);
		}
	}
}
