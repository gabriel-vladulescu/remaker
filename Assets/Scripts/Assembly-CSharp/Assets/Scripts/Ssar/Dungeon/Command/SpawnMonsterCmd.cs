using System;
using Artemis;
using Assets.Scripts.Ssar.Common.System.Resources;
using Assets.Scripts.Ssar.Dungeon.GameModeLogic;
using Assets.Scripts.Ssar.Dungeon.Model;
using Assets.Scripts.Ssar.Dungeon.Signal;
using strange.extensions.command.impl;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class SpawnMonsterCmd : strange.extensions.command.impl.Command
	{
		[Inject]
		public MobSpawnInfo MobSpawnInfo { get; set; }

		[Inject]
		public ResourcesLoader resourcesLoader { get; set; }

		[Inject]
		public Action<Entity> onSpawnSuccess { get; set; }

		[Inject]
		public FinishSpawnMonsterSignal FinishSpawnMonsterSignal { get; set; }

		[Inject]
		public IBattleModeLogic BattleModeLogic { get; set; }

		public override void Execute()
		{
		}

		private static void CastPassiveSkills(Entity monster, int groupId, int subId)
		{
		}
	}
}
