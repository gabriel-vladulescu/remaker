using SSAR.Dungeon.View;
using Ssar.DailyChallenge.Model;

namespace Ssar.DailyChallenge.View
{
	public class ChallengeModifierVisualInfo : IModifierVisualInfo
	{
		private ModifierVisualType type;

		private string icon;

		private int stack;

		public ChallengeModifierVisualInfo(BuffType buffType, string icon)
		{
		}

		public float TimeRemaining()
		{
			return 0f;
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

		public void AddStack(int count = 1)
		{
		}

		public static ModifierVisualType TransferType(BuffType buffType)
		{
			return default(ModifierVisualType);
		}
	}
}
