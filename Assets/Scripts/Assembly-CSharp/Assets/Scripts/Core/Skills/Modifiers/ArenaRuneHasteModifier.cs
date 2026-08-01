using Artemis;

namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class ArenaRuneHasteModifier : MovementSpeedModifier
	{
		public ArenaRuneHasteModifier(MovementSpeedInfo info, Entity target)
			: base(null, null)
		{
		}

		public override ModifierType Type()
		{
			return default(ModifierType);
		}
	}
}
