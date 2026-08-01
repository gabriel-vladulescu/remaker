using System;
using System.Collections.Generic;
using Assets.Scripts.Ssar.Combat.Effects.Pool;
using Assets.Scripts.Ssar.Combat.Skills.Pool;
using Assets.Scripts.Ssar.Common.System.Resources;
using SSAR.BattleSystem.Effect;

namespace Assets.Scripts.Core.Skills
{
	internal class EffectPoolBuilder
	{
		private PreloadPool preloadPool;

		private ResourcesLoader resourcesLoader;

		public EffectPoolBuilder(ref PreloadPool preloadPool, ResourcesLoader resourcesLoader)
		{
		}

		public void Build(Action<EffectPool> onCompleted)
		{
		}

		private EffectPool InitEffectPool(List<PrefabItem> prefabItems, EffectEditorInfo[] eeis)
		{
			return null;
		}
	}
}
