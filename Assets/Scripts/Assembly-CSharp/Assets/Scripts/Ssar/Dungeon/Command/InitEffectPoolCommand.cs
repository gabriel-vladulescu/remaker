using System.Collections.Generic;
using Assets.Scripts.Ssar.Combat.Skills.Pool;
using Assets.Scripts.Ssar.Common.System.Resources;
using SSAR.BattleSystem.Effect;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class InitEffectPoolCommand : strange.extensions.command.impl.Command
	{
		[Inject]
		public PreloadPool preloadPool { get; set; }

		[Inject]
		public ResourcesLoader resourcesLoader { get; set; }

		public override void Execute()
		{
		}

		private void InitEffectPool(List<PrefabItem> prefabItems, EffectEditorInfo[] eeis)
		{
		}
	}
}
