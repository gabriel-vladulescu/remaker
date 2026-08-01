using Artemis;
using Assets.Scripts.Ssar.Dungeon.Signal;
using SSAR.BattleSystem.EntityTemplate;
using SSAR.BattleSystem.System.Arena.Model;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class SpawnArenaEnemyCmd : AbsSpawnCharacterCmd
	{
		private ArenaEnemyData arenaEnemy;

		[Inject]
		public OnSpawnRightArenaCharacterSignal OnSpawnRightArenaCharacterSignal { get; set; }

		public override void Execute()
		{
		}

		protected override MainCharacterData MainCharacterData()
		{
			return null;
		}

		protected override Vector3 PositionSpawn()
		{
			return default(Vector3);
		}

		protected override Entity CreateEntityFromTemplate(MainCharacterTemplateArgs args)
		{
			return null;
		}

		protected override void CreateEntityFinish(Entity entity)
		{
		}
	}
}
