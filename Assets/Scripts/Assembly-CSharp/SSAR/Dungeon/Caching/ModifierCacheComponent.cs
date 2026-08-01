using System.Collections.Generic;
using Artemis.Interface;
using Assets.Scripts.Core.Skills.Modifiers;
using SSAR.Dungeon.View;

namespace SSAR.Dungeon.Caching
{
	public class ModifierCacheComponent : IComponent
	{
		private Dictionary<Modifier, DefaultModifierVisualInfo> dict;

		private List<IModifierVisualInfo> specialModifierVisualInfos;

		public void AddPassive(Modifier modifier)
		{
		}

		public void ForceRemoveModifier(Modifier modifier)
		{
		}

		public void AddSpecialModifierVisualInfo(IModifierVisualInfo specialModifierVisualInfo)
		{
		}

		public void ForceAddSpecialModifier(IModifierVisualInfo specialModifierVisualInfo)
		{
		}

		public void AddOrReplaceSpecialModifierVisualInfo(IModifierVisualInfo modifierVisualInfo)
		{
		}

		public IModifierVisualInfo GetSpecialModifier(ModifierVisualType type)
		{
			return null;
		}

		public void RemoveSpecialModifier(IModifierVisualInfo modifierVisualInfo)
		{
		}

		public DefaultModifierVisualInfo GetModifierVisualInfo(Modifier modifier)
		{
			return null;
		}

		public List<IModifierVisualInfo> GetListSpecialModifierVisualInfos()
		{
			return null;
		}
	}
}
