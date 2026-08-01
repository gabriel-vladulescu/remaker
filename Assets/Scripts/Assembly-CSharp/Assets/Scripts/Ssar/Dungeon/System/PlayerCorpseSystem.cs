using Artemis.System;
using Assets.Scripts.Ssar.Common.System.Resources;
using Assets.Scripts.Ssar.Dungeon.Model;
using Assets.Scripts.Ssar.Dungeon.View;

namespace Assets.Scripts.Ssar.Dungeon.System
{
	public class PlayerCorpseSystem : EntitySystem
	{
		private readonly ResourcesLoader _resourcesLoader;

		private PlayerCorpseTombView tomb;

		public PlayerCorpseSystem(ResourcesLoader resourcesLoader)
		{
		}

		public override void UnloadContent()
		{
		}

		public void Spawn(PlayerCorpseData data)
		{
		}

		public void DestroyTomb()
		{
		}
	}
}
