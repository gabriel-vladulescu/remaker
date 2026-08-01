namespace Assets.Scripts.Core.Skills.Modifiers
{
	public class ModifierDuration
	{
		public static ModifierDuration FOREVER;

		private float duration;

		public ModifierDuration(float duration)
		{
		}

		public float Value()
		{
			return 0f;
		}

		public bool IsForever()
		{
			return false;
		}
	}
}
