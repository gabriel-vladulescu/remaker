namespace SSAR.Dungeon.View
{
	public class SpecialModifierVisualInfo : IModifierVisualInfo
	{
		private ModifierVisualType type;

		private float remainingTime;

		public SpecialModifierVisualInfo(PassiveSkillCode type)
		{
		}

		public SpecialModifierVisualInfo(ModifierVisualType modifierVisualType)
		{
		}

		public float TimeRemaining()
		{
			return 0f;
		}

		public void UpdateRemainingTime(float t)
		{
		}

		public ModifierVisualType Type()
		{
			return default(ModifierVisualType);
		}

		public bool IsPassive()
		{
			return false;
		}

		public bool HasCustomIcon()
		{
			return false;
		}

		public string Icon()
		{
			return null;
		}

		public bool HasCustomText()
		{
			return false;
		}

		public string Text()
		{
			return null;
		}

		private ModifierVisualType Transfer(PassiveSkillCode code)
		{
			return default(ModifierVisualType);
		}
	}
}
