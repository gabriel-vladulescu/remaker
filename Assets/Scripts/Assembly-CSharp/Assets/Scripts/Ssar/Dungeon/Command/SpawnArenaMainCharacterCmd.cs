using Artemis;
using Assets.Scripts.Ssar.Dungeon.Signal;
using SSAR.BattleSystem.EntityTemplate;
using UnityEngine;

namespace Assets.Scripts.Ssar.Dungeon.Command
{
	public class SpawnArenaMainCharacterCmd : AbsSpawnCharacterCmd
	{
		private MainCharacterData mainCharacterData;

		[Inject]
		public OnSpawnMainCharacterSignal OnSpawnMainCharacterSignal { get; set; }

		[Inject]
		public OnSpawnLeftArenaCharacterSignal OnSpawnLeftArenaCharacterSignal { get; set; }

		[Inject]
		public DisableInputAndAISignal DisableInputAndAiSignal { get; set; }

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

		protected override bool EnableModifyStatTest()
		{
			return false;
		}
	}
}
