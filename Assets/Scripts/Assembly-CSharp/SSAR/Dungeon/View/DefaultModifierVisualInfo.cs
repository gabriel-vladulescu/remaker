using Assets.Scripts.Core.Skills.Modifiers;

namespace SSAR.Dungeon.View
{
	public class DefaultModifierVisualInfo : IModifierVisualInfo
	{
		private Modifier modifier;

		private bool isPassive;

		private ModifierVisualType visualType;

		public DefaultModifierVisualInfo(Modifier modifier, bool isPassive)
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

		public void ChangeToPassive()
		{
		}

		private ModifierVisualType TransferType(ModifierType type)
		{
			return default(ModifierVisualType);
		}
	}
}
