using Artemis;
using Assets.Scripts.Ssar.Dungeon.Configs;
using Assets.Scripts.Ssar.Dungeon.Signal;
using SSAR.BattleSystem.EntityTemplate;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class SpawnMainCharacterCmd : AbsSpawnCharacterCmd
	{
		[Inject]
		public DungeonConfig dungeonConfig { get; set; }

		[Inject]
		public OnSpawnMainCharacterSignal OnSpawnMainCharacterSignal { get; set; }

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

		private void CheckBoostItem(Entity entity)
		{
		}

		protected override bool EnableModifyStatTest()
		{
			return false;
		}
	}
}
